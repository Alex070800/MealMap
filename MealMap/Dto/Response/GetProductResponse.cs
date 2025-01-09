using MealMap.Models;

namespace MealMap.Dto.Response
{
    public class GetProductResponse
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
        /// Категория продукта (на будущее, для статистики)
        /// </summary>
    }
}
