using MealMap.Models;

namespace MealMap.Dto.Response
{
    public class GetMealTypesResponse
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
        /// Порядкой номер
        /// </summary>
        public int Order { get; set; }

        public static explicit operator GetMealTypesResponse(List<MealType> v)
        {
            throw new NotImplementedException();
        }
    }
}

