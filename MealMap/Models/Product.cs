using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    /// 
    [Table("products")]
    public class Product
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

        /// <summary>
        /// Категория продукта (на будущее, для статистики)
        /// </summary>
        public virtual Category? Category { get; set; }

    }
}
