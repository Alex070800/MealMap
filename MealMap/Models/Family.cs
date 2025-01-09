using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Семья
    /// </summary>
    /// 
    [Table("families")]
    public class Family
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }
        /// <summary>
        /// Название семье
        /// </summary>

        [Column("name")]

        public string Name { get; set; }
        /// <summary>
        /// Члены семьи
        /// </summary>
        public virtual List<User> Users { get; set; }
        /// <summary>
        /// Член семьи, определяющий меню семьи (главный по кухне)
        /// </summary>
        public virtual User? Master { get; set; }
        /// <summary>
        /// Меню семьи
        /// </summary>
        public virtual Menu Menu { get; set; }
    }
}
