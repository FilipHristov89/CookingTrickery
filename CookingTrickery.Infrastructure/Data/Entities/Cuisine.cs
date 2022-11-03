namespace CookingTrickery.Infrastructure.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    using static Data.Common.Constants.CuisineConstants;

    public class Cuisine
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(CuisineNameMaxLenght)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(CuisineDescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        public ICollection<User> UsersFavorites { get; set; } = new List<User>();
    }
}
