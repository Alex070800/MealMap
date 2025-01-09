namespace MealMap.Dto.Request
{
    public class PatchFamilyRequest
    {
        /// <summary>
        /// Id семьи
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Id пользователя, который будет отвечать за приготовление пищи
        /// </summary>
        public int? NewMaserId { get; set; }
        /// <summary>
        /// Новое название
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Id новых пользователей
        /// </summary>
        public List<int>? NewUsers { get; set; }
    }
}
