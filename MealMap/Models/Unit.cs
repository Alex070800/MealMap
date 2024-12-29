namespace MealMap.Models
{
    /// <summary>
    /// Мера измерения продукта в рецепте (кг, ст. ложки и тд)
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
    }
}
