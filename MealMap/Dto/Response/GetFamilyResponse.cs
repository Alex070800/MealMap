using MealMap.Models;

namespace MealMap.Dto.Response
{
    public class GetFamilyResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Название семье
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ответственный за приготовление пищи
        /// </summary>
        public string MasterName { get; set; }
        /// <summary>
        /// Члены семьи
        /// </summary>
        public List<UserInFamilyDto>? Users { get; set; }
    }
}
