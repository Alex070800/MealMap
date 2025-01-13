using MealMap.Context;
using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Dto;
using MealMap.Models;
using Microsoft.EntityFrameworkCore;

namespace MealMap.Service
{
    public class DayService
    {
        public List<GetDayResponse> Get()
        {
            using (MealMapContext context = new MealMapContext())
            {

                List<Day> days = context.Days
                    .Include(d => d.Desks)
                        .ThenInclude(desk => desk.Dishs)
                            .ThenInclude(dish => dish.Recipe)
                    .Include(d => d.Desks)
                        .ThenInclude(desk => desk.Dishs)
                            .ThenInclude(dish => dish.User).ToList();
               

                return days.Select(d => new GetDayResponse()
                {
                    Id = d.Id,
                    Date = d.Date.ToString("d"),
                    Desks = d.Desks.Select(deskItem => new GetDesk()
                    {
                        Id = deskItem.Id,
                        MealTypeName = deskItem.Type.Name,
                        Dishes = deskItem.Dishs.Select(dishItem => new GetDish()
                        {
                            Id = dishItem.Id,
                            Name = dishItem.Recipe.Name,
                            UserName = dishItem.User.Name
                        }).ToList(),
                    }).ToList()
                }).ToList();
            }
        }
        public GetDayResponse Create(PostDayRequest dayDto)
        {
            using (MealMapContext context = new MealMapContext())
            {
                Day day = new Day() { Date = dayDto.Date, Desks = new List<Desk>() };
                foreach (CreateDesk desk in dayDto.Desks)
                {
                    MealType? type = context.MealTypes.FirstOrDefault(t => t.Id == desk.IdMealType);
                    Desk newDesk = new Desk() { Dishs = new List<Dish>()};
                    newDesk.Type = type != null ? type : context.MealTypes.FirstOrDefault();

                    foreach (CreateDish dish in desk.Dishes)
                    {
                        User userCook = context.Users.FirstOrDefault(u => u.Id == dish.IdUser);
                        Recipe recipe = context.Recipes.FirstOrDefault(r => r.Id == dish.IdRecipe);
                        Dish newDish = new Dish() { User = userCook, Recipe = recipe };
                        newDesk.Dishs.Add(newDish);
                    }
                    day.Desks.Add(newDesk);
                }
                Family family = context.Families.Include(f => f.Menu).ThenInclude(f => f.Days).FirstOrDefault();
                family.Menu.Days.Add(day);
                //context.Days.Add(day);
                context.SaveChanges();

                return new GetDayResponse()
                {
                    Id = day.Id,
                    Date = day.Date.ToString("d"),
                    Desks = day.Desks.Select(deskItem => new GetDesk()
                    {
                        Id = deskItem.Id,
                        MealTypeName = deskItem.Type.Name,
                        Dishes = deskItem.Dishs.Select(dishItem => new GetDish()
                        {
                            Id = dishItem.Id,
                            Name = dishItem.Recipe.Name,
                            UserName = dishItem.User.Name
                        }).ToList(),
                    }).ToList()
                };
            }
        }

        public void Delete(int id)
        {
            using (MealMapContext context = new MealMapContext())
            {
                context.Days.Where(d => d.Id == id).ExecuteDeleteAsync();
                context.SaveChanges();
            }
        }
    }
}
