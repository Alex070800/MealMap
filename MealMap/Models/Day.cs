namespace MealMap.Models
{
    /// <summary>
    /// День
    /// </summary>
    public class Day
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        public DateOnly Date {  get; set; }
        /// <summary>
        /// Список столов в этот день
        /// </summary>
        public List<Desk> Desks { get; set; } 
    }
}
