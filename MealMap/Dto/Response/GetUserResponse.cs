namespace MealMap.Dto.Response
{
    public class GetUserResponse
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Id семьи
        /// </summary>
        public int? FamilyId { get; set; }

        /// <summary>
        /// Является ли пользователь мастером в своей семье
        /// </summary>
        public bool? IsMaster { get; set; }

        /// <summary>
        /// Фото
        /// </summary>
        public string? Photo {  get; set; }
    }
}
