namespace MealMap.Dto.Response
{
    public class GetRecipeResponse
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
        /// Продолжительность приготовления в минутах
        /// </summary>
        public int DurationMinutes { get; set; }

        /// <summary>
        /// Компоненты рецепта
        /// </summary>
        public List<GerComponentInRecipe> Components { get; set; }

    }
}
