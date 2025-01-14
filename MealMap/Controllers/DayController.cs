using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Service;
using Microsoft.AspNetCore.Mvc;

namespace MealMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayController : ControllerBase
    {
        private readonly ILogger<DayController> _logger;
        private DayService? dayService;
       
        public DayController(ILogger<DayController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            dayService = serviceProvider.GetService<DayService>();
        }

        [HttpGet]
        public IEnumerable<GetDayResponse> Get()
        {
            try
            {
                return dayService.Get();
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        /// <summary>
        /// Добавление дня
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public GetDayResponse Post(PostDayRequest postDayRequest)
        {
            try
            {
                return dayService.Create(postDayRequest);
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
                dayService.Delete(id);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
