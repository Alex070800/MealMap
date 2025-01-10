using System.ComponentModel.DataAnnotations.Schema;

namespace MealMap.Models
{
    /// <summary>
    /// Согласие (подтверждение) стола
    /// </summary>
    [Table("agreements")]
    public class Agreement
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("id")]
        public int Id { get; set; }

        /// <summary>
        /// Член семье, который дает свое согласие на стол
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Стол, который подлежит утверждению
        /// </summary>
        public virtual Desk Desk { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        [Column("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Согласен ли пользователь с составом стола
        /// </summary>
        [Column("is_agree")]
        public bool IsAgree { get; set; }
    }
}
