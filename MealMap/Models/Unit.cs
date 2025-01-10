using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Мера измерения продукта в рецепте (кг, ст. ложки и тд)
    /// </summary>
    [Table("units")]
    public class Unit
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Column("name")]
        public string Name { get; set; }
    }
}
