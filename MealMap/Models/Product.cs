namespace MealMap.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; } 
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Категория продукта (на будущее, для статистики)
        /// </summary>
        public Category? Category { get; set; }

    }
}
