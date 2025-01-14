using MealMap.Context;
using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Models;
using MealMap.Service;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MealMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipeController : ControllerBase
    {
      
        private readonly ILogger<RecipeController> _logger;
        private RecipeService? recipeService;
       

        public RecipeController(ILogger<RecipeController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            recipeService = serviceProvider.GetService<RecipeService>();
        }

        ///// <summary>
        ///// Получить все продукты
        ///// </summary>
        ///// <returns></returns>
        [HttpGet]
        public GetRecipeResponse Get(int id)
        {
            try
            {
                return recipeService.Get(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        /// <summary>
        /// Добавление нового рецепта
        /// </summary>
        /// <param name="postRecipeRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public GetRecipeResponse Post(PostRecipeRequest postRecipeRequest)
        {
            try
            {
                return recipeService.Create(postRecipeRequest);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [HttpDelete]
        public void Delete(int id)
        {
            try
            {
                recipeService.Delete(id);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
