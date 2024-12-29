namespace MealMap.Models
{
    /// <summary>
    /// Рецепт
    /// </summary>
    public class Recipe
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
        /// Фото (либо ссылка на файл, либо base64, на будущее)
        /// </summary>
        public string? Photo {  get; set; }  
        /// <summary>
        /// Продолжительность приготовления в минутах
        /// </summary>
        public int DurationMinutes { get; set; }
        /// <summary>
        /// Список ингридиентов
        /// </summary>
        public List<Component> Components { get; set; }

    }
}
