
using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Service;
using Microsoft.AspNetCore.Mvc;

namespace MealMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FamilyController : ControllerBase
    {


        private readonly ILogger<DictionaryController> _logger;
        private FamilyService? familyService;


        public FamilyController(ILogger<DictionaryController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            familyService = serviceProvider.GetService<FamilyService>();
        }

        /// <summary>
        /// Получить данные о своей семье
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public GetFamilyResponse Get()
        {
            try
            {
                return familyService.Get();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [HttpPost]
        public GetFamilyResponse Post(PostFamilyRequest postFamilyRequest)
        {
            try
            {
                return familyService.Create(postFamilyRequest);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [HttpPatch]
        public GetFamilyResponse Patch(PatchFamilyRequest putFamilyRequest)
        {
            try
            {
                return familyService.Update(putFamilyRequest);
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
                familyService.Delete(id);
            }
            catch (Exception ex)
            {

            }
        }

    }
}
