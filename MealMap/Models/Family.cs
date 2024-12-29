namespace MealMap.Models
{
    /// <summary>
    /// Семья
    /// </summary>
    public class Family
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
        /// Члены семьи
        /// </summary>
        public List<User> Users { get; set; }
        /// <summary>
        /// Член семьи, определяющий меню семьи (главный по кухне)
        /// </summary>
        public User Master { get; set; }
        /// <summary>
        /// Меню семьи
        /// </summary>
        public Menu Menu { get; set; }  
    }
}
