using MealMap.Models;

namespace MealMap.Dto.Response
{
    public class GetDayResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public string Date {  get; set; }

        /// <summary>
        /// Список приемов пищи (столов) на эту дату
        /// </summary>
        public List<GetDesk> Desks { get; set; }
    }
}
