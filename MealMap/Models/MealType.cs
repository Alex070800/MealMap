using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Тип приема пищи (обед, ужин и тд)
    /// </summary>
    [Table("meal_types")]
    public class MealType
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
        /// Порядкой номер
        /// </summary>
        [Column("order")]
        public int Order { get; set; }
    }
}
