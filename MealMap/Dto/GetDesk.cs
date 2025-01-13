namespace MealMap.Dto
{
    public class GetDesk
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Тип приема пищи
        /// </summary>
        public string MealTypeName { get; set; }
       
        /// <summary>
        /// Список блюд
        /// </summary>
        public List<GetDish> Dishes { get; set; }   
    }
}
