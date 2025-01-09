namespace MealMap.Dto
{
    public class CreateComponentInRecipe
    {
        /// <summary>
        /// Id продукта
        /// </summary>
        public int IdProduct { get; set; }
        /// <summary>
        /// Id меры измерения
        /// </summary>
        public int IdUnit { get; set; }
        /// <summary>
        /// Количество
        /// </summary>
        public int Count { get; set; }
    }
}
