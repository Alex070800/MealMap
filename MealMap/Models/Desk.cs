using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Стол (прием пищи)
    /// </summary>
    [Table("desks")]
    public class Desk
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Тип приема пищи (завтрак, обед и тд)
        /// </summary>
        public virtual MealType Type { get; set; }

        /// <summary>
        /// Список блюд на столе
        /// </summary>
        public virtual List<Dish> Dishs { get; set; } = new List<Dish>();

        /// <summary>
        /// Все согласия семьи
        /// </summary>
        public virtual List<Agreement> Agreements { get; set; } = new List<Agreement>();
    }
}
