namespace MealMap.Models
{
    /// <summary>
    /// Стол (прием пищи)
    /// </summary>
    public class Desk
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Тип приема пищи (завтрак, обед и тд)
        /// </summary>
        public MealType Type { get; set; }
        /// <summary>
        /// Список блюд на столе
        /// </summary>
        public List<Dish> Dishs { get; set; }
        /// <summary>
        /// Все согласия семьи
        /// </summary>
        public List<Agreement> Agreements { get; set; }
    }
}
