namespace MealMap.Dto
{
    public class GetDish
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
    
        /// <summary>
        /// Название блюда
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Имя пользователя, который несет ответственность за приготовление блюда
        /// </summary>
        public string UserName { get; set; }
    }
}
