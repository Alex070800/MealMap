namespace MealMap.Dto.Request
{
    public class PostUserRequest
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}
