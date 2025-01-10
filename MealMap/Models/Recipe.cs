using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Рецепт
    /// </summary>
    [Table("recipes")]
    public class Recipe
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Column("name")]
        public string Name { get; set; }

        /// <summary>
        /// Фото (либо ссылка на файл, либо base64, на будущее)
        /// </summary>
        [Column("photo")]
        public string? Photo {  get; set; }

        /// <summary>
        /// Продолжительность приготовления в минутах
        /// </summary>
        /// 
        [Column("duration_minutes")]
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Список ингридиентов
        /// </summary>
        public virtual List<Component> Components { get; set; }

    }
}
