namespace MealMap.Models
{
    /// <summary>
    /// Согласие (подтверждение) стола
    /// </summary>
    public class Agreement
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Член семье, который дает свое согласие на стол
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Стол, который подлежит утверждению
        /// </summary>
        public Desk Desk { get; set; }
        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        /// Согласен ли пользователь с составом стола
        /// </summary>
        public bool IsAgree { get; set; }
    }
}
