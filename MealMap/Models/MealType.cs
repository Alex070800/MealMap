namespace MealMap.Models
{
    /// <summary>
    /// Тип приема пищи (обед, ужин и тд)
    /// </summary>
    public class MealType
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
        /// Порядкой номер
        /// </summary>
        public int Order { get; set; }
    }
}
