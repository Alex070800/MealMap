namespace MealMap.Dto.Request
{
    public class PostRecipeRequest
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Продолжительность приготовления в минутах
        /// </summary>
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Компоненты рецепта
        /// </summary>
        public List<CreateComponentInRecipe> ComponentIns { get; set; }
    }
}
