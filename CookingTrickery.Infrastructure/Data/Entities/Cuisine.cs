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
        [MaxLength(CuisineNameMaxLength)]
        public string Name { get; set; } = null!;
        
        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(CuisineDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

        public ICollection<User> UsersFavorites { get; set; } = new List<User>();
    }
}
