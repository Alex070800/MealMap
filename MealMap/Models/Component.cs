using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Ингридиент рецепта
    /// </summary>
    [Table("components")]

    public class Component
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Продукт
        /// </summary>
        public virtual Product Product { get; set; }
       
        /// <summary>
        /// Мера измерения ингридента в рецепте
        /// </summary>
        public virtual Unit Unit { get; set; }
        
        /// <summary>
        /// Количество продукта в рецепте
        /// </summary>
        [Column("count")]
        public int Count { get;set; }
    }
}
