using MealMap.Models;

namespace MealMap.Dto
{
    public class GetMealTypeResponse
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

        public static explicit operator GetMealTypeResponse(List<MealType> v)
        {
            throw new NotImplementedException();
        }
    }
}

