using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    /// 
    [Table("users")]
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Семья
        /// </summary>
        public virtual Family? Family { get; set; }

        /// <summary>
        /// Рецепты пользователя
        /// </summary>
        public virtual List<Recipe>? Recipes { get; set; }

        /// <summary>
        /// Блюда, которые должен готовить пользовтаеля
        /// </summary>
        public virtual List<Dish>? Dishes { get; set; } 

        /// <summary>
        /// Логин
        /// </summary>
        [Column("login")]
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        [Column("password")]
        public string Password { get; set; }
    }
}
