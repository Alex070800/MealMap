using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Меню семьи
    /// </summary>
    /// 
    [Table("menu")]
    public class Menu
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дни
        /// </summary>
        public virtual List<Day>? Days { get; set; }
    }
}
