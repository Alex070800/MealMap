using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Пользователь
    /// </summary>
    /// 
    [Table("users")]
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Семья
        /// </summary>
        public virtual Family Family { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }
    }
}
