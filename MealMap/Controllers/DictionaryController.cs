using MealMap.Context;
using MealMap.Models;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet(Name = "G")]
        public IEnumerable<MealType> Get()
        {
            try
            {
                using (MealMapContext context = new MealMapContext())
                {
                    return context.MealTypes.ToList();
                    
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
