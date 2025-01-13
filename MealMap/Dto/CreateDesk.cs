namespace MealMap.Dto
{
    public class CreateDesk
    {
        /// <summary>
        /// Id типа приема пищи
        /// </summary>
        public int IdMealType {  get; set; }    
        
        /// <summary>
        /// Список блюд
        /// </summary>
        public List<CreateDish> Dishes { get; set; }
    }
}
