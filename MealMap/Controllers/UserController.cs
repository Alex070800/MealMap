using MealMap.Dto.Request;
using MealMap.Dto.Response;
using MealMap.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MealMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private UserService? userService;

        public UserController(ILogger<UserController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            userService = serviceProvider.GetService<UserService>();
        }

        /// <summary>
        /// Получение данных о пользователе
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public GetUserResponse Get()
        {
            try
            {
                return userService.Get();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        /// <param name="postUserRequest"></param>
        [HttpPost]
        public IResult Post(PostUserRequest postUserRequest)
        {
            try
            {
                return userService.Create(postUserRequest);
            }
            catch (Exception ex)
            {
                return Results.StatusCode(500);
            }
        }

    }
}
