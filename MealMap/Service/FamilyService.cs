using MealMap.Context;
using MealMap.Dto;
using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Models;
using Microsoft.EntityFrameworkCore;

namespace MealMap.Service
{
    public class FamilyService
    {
        public GetFamilyResponse Get()
        {
            using (MealMapContext context = new MealMapContext())
            {
                Family f = context.Families.Include(f => f.Users).Include(f => f.Menu).First();
                GetFamilyResponse family = new GetFamilyResponse()
                {
                    Id = f.Id,
                    Name = f.Name,
                    MasterName = f?.Master?.Name,
                    Users = f.Users?.Select(u => new UserInFamily()
                    {
                        Name = u.Name,
                        Id = u.Id,
                    }).ToList()
                };
                return family;
            }

        }

        public GetFamilyResponse Create(PostFamilyRequest familyDto)
        {
            using (MealMapContext context = new MealMapContext())
            {
                Family family = new Family() { Name = familyDto.Name };
                User? user = null; ;
                try
                {
                     user = context.Users.FirstOrDefault(u => u.Id == familyDto.MasterId);

                }
                catch(Exception ex) 
                {

                }
                if (user != null)
                {
                    family.Master = user;
                    user.Family = family;
                }
                //context.SaveChanges();

                context.Families.Add(family);
                context.SaveChanges();
                return new GetFamilyResponse()
                {
                    Id = family.Id,
                    Name = family.Name,
                    MasterName = family?.Master?.Name,
                    Users = family.Users?.Select(u => new UserInFamily()
                    {
                        Name = u.Name,
                        Id = u.Id,
                    }).ToList()
                };
            }

        }

        public GetFamilyResponse Update(PatchFamilyRequest familyDto)
        {
            using (MealMapContext context = new MealMapContext())
            {
                Family family = context.Families.Include(f => f.Users).FirstOrDefault(f => f.Id == familyDto.Id);

                if (family != null)
                {

                    ///Меняем мастера кухни
                    if (familyDto.NewMaserId != null)
                    {
                        User master = context.Users.Include(u => u.Family).FirstOrDefault(u => u.Id == familyDto.NewMaserId);
                        if (master != null && family.Users.Contains(master))
                        {
                            family.Master = master;
                        }
                    }

                    ///Меняем название семьи
                    if (familyDto.Name != null)
                    {
                        family.Name = familyDto.Name;
                    }

                    ///Добавляем новых пользователей
                    if (familyDto.NewUsers != null)
                    {
                        foreach (int idNewUser in familyDto.NewUsers)
                        {
                            User newUser = context.Users.Include(u => u.Family).FirstOrDefault(u => u.Id == idNewUser);
                            if (newUser != null)
                            {
                                family.Users.Add(newUser);
                            }
                        }
                    }

                    context.SaveChanges();
                    return new GetFamilyResponse()
                    {
                        Id = family.Id,
                        Name = family.Name,
                        MasterName = family?.Master?.Name,
                        Users = family.Users?.Select(u => new UserInFamily()
                        {
                            Name = u.Name,
                            Id = u.Id,
                        }).ToList()
                    };

                }
                else
                {
                    return null;
                }

            }
        }

        public void Delete(int id)
        {
            using (MealMapContext context = new MealMapContext())
            {
               context.Families.Where(f => f.Id == id).ExecuteDeleteAsync();
                context.SaveChanges();
            }
        }
    }
}
