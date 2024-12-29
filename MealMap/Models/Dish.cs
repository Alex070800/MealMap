namespace MealMap.Models
{
    /// <summary>
    /// Блюдо
    /// </summary>
    public class Dish
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Рецепт
        /// </summary>
        public Recipe Recipe { get; set; }
        /// <summary>
        /// Ответственное лицо, которое будет его готовить
        /// </summary>
        public User User { get; set; }
    }
}
