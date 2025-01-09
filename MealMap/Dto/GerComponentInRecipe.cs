namespace MealMap.Dto
{
    public class GerComponentInRecipe
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название продукта
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Название меры измерения
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        public int Count {  get; set; } 
    }
}
