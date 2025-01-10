using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Блюдо
    /// </summary>
    [Table("dishs")]
    public class Dish
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Рецепт
        /// </summary>
        public virtual Recipe Recipe { get; set; }
       
        /// <summary>
        /// Ответственное лицо, которое будет его готовить
        /// </summary>
        public User User { get; set; }
    }
}
