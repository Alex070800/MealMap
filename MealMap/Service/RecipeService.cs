using MealMap.Context;
using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Dto;
using MealMap.Models;
using Microsoft.EntityFrameworkCore;

namespace MealMap.Service
{
    public class RecipeService
    {
        public GetRecipeResponse Get(int id)
        {
            using (MealMapContext context = new MealMapContext())
            {
                Recipe? r = context.Recipes.Include(r => r.Components).ThenInclude(c => c.Product).Include(r => r.Components).ThenInclude(c => c.Unit).FirstOrDefault(r => r.Id == id);
                if (r != null)
                {
                    GetRecipeResponse recipt = new GetRecipeResponse()
                    {
                        Id = r.Id,
                        Name = r.Name,
                        DurationMinutes = r.DurationMinutes,
                        Components = r.Components.Select(c => new GerComponentInRecipe()
                        {
                            Id = c.Id,
                            ProductName = c.Product.Name,
                            Count = c.Count,
                            UnitName = c.Unit.Name
                        }).ToList()
                    };
                    return recipt;
                }
                else return null;
            }
        }
        public GetRecipeResponse Create(PostRecipeRequest recipeDto)
        {
            using (MealMapContext context = new MealMapContext())
            {
                Recipe recipe = new Recipe() { Name = recipeDto.Name, DurationMinutes = recipeDto.DurationMinutes, Components = new List<Component>() };
                foreach (CreateComponentInRecipe c in recipeDto.ComponentIns)
                {
                    Component component = new Component();
                    component.Count = c.Count;
                    Product? product = context.Products.FirstOrDefault(p => p.Id == c.IdProduct);
                    if (product != null)
                    {
                        component.Product = product;
                    }
                    Unit? unit = context.Units.FirstOrDefault(u => u.Id == c.IdUnit);
                    if (unit != null)
                    {
                        component.Unit = unit;
                    }
                    context.Components.Add(component);
                    recipe.Components.Add(component);
                }
                context.Recipes.Add(recipe);
                context.SaveChanges();

                return new GetRecipeResponse()
                {
                    Id = recipe.Id,
                    Name = recipe.Name,
                    DurationMinutes = recipe.DurationMinutes,
                    Components = recipe.Components.Select(c => new GerComponentInRecipe()
                    {
                        Id = c.Id,
                        ProductName = c.Product.Name,
                        Count = c.Count,
                        UnitName = c.Unit.Name
                    }).ToList()
                };
            }
        }
        public void Delete(int id)
        {
            using (MealMapContext context = new MealMapContext())
            {
                context.Recipes.Where(r => r.Id == id).ExecuteDeleteAsync();
                context.SaveChanges();
            }
        }
    }
}
