namespace MealMap.Models
{
    /// <summary>
    /// Ингридиент рецепта
    /// </summary>
    public class Component
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Продукт
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Мера измерения ингридента в рецепте
        /// </summary>
        public Unit Unit { get; set; }
        /// <summary>
        /// Количество продукта в рецепте
        /// </summary>
        public int Count { get;set; }
    }
}
