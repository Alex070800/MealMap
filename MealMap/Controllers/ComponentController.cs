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
    public class ComponentController : ControllerBase
    {
       

        private readonly ILogger<DictionaryController> _logger;
        private ProductService? productService;
       

        public ComponentController(ILogger<DictionaryController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            productService = serviceProvider.GetService<ProductService>();
        }

        /// <summary>
        /// Получить все продукты
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<GetProductResponse> Get()
        {
            try
            {
                return productService.Get();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
    }
}
