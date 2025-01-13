namespace MealMap.Dto.Request
{
    public class PostDayRequest
    {
        /// <summary>
        /// Дата
        /// </summary>
        public DateOnly Date {  get; set; }

        /// <summary>
        /// Список всех приемов пищи в этот день
        /// </summary>
        public List<CreateDesk> Desks { get; set; }
    }
}
