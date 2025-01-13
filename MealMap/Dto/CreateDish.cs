namespace MealMap.Dto
{
    public class CreateDish
    {
        /// <summary>
        /// Id рецепта
        /// </summary>
        public int IdRecipe { get;set; }
        /// <summary>
        /// Id ответственного лица
        /// </summary>
        public int IdUser { get; set; }
    }
}
