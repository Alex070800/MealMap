using System.ComponentModel.DataAnnotations;

namespace MealMap.Dto.Request
{
    public class PostFamilyRequest
    {
        /// <summary>
        /// Название семьи
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Id пользователя, который будет отвечать за приготовление пищи в семье
        /// </summary>
        public int? MasterId { get; set; }
    }
}
