using MealMap.Context;
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
    public class DictionaryController : ControllerBase
    {
       

        private readonly ILogger<DictionaryController> _logger;
        private MealTypeService? mealTypeService;
        private UnitService? unitService;

        public DictionaryController(ILogger<DictionaryController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            mealTypeService = serviceProvider.GetService<MealTypeService>();
            unitService = serviceProvider.GetService<UnitService>();
        }

        /// <summary>
        /// Тип приема пищи
        /// </summary>
        /// <returns></returns>
        [HttpGet("MealTypes")]
        public IEnumerable<GetMealTypesResponse> MealTypes()
        {
            try
            {
                return mealTypeService.Get();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        

        /// <summary>
        /// Мера измерения
        /// </summary>
        /// <returns></returns>
        [HttpGet("Units")]
        public IEnumerable<GetUnitsResponse> Units()
        {
            try
            {
                return unitService.Get();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
