using MealMap.Context;
using MealMap.Dto;
using MealMap.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MealMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DictionaryController : ControllerBase
    {
       

        private readonly ILogger<DictionaryController> _logger;

        public DictionaryController(ILogger<DictionaryController> logger)
        {
            _logger = logger;
        }

        [HttpGet("MealType")]
        public IEnumerable<GetMealTypeResponse> MealType()
        {
            try
            {
                using (MealMapContext context = new MealMapContext())
                {
                    return context.MealTypes.Select( o => new GetMealTypeResponse() { Id=o.Id, Name = o.Name, Order = o.Order}).ToList();
                    
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
