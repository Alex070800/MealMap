using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// День
    /// </summary>
    [Table("days")]
    public class Day
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        [Column("date")]
        public DateOnly Date {  get; set; }

        /// <summary>
        /// Список столов в этот день
        /// </summary>
        public virtual List<Desk> Desks { get; set; } = new List<Desk>();
    }
}
