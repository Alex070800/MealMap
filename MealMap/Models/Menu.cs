namespace MealMap.Models
{
    /// <summary>
    /// Меню семьи
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Дни
        /// </summary>
        public List<Day> Days { get; set; }
    }
}
