namespace CookingTrickery.Infrastructure.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Data.Common.Constants.RecipeConstants;
    public class Recipe
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(RecipeNameMaxLenght)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(RecipeQuickDecriptionMaxLenght)]
        public string QuickDescription { get; set; } = null!;

        public ICollection<IngredientMeasurement> Ingredients { get; set; } = new List<IngredientMeasurement>();
        
        public Guid CuisineId { get; set; }
        [ForeignKey(nameof(CuisineId))]
        public Cuisine? Cuisine { get; set; }

        [Required]
        [MaxLength(RecipeDescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        public int NumberOfServing { get; set; }

        [Required]
        [MaxLength(RecipePrepTimeMaxLength)]
        public string PrepTime { get; set; } = null!;

        public double? Rating { get; set; }

        [Required]
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public User User { get; set; } = null!;

        public ICollection<UsersFavorites> UsersFavorites { get; set; } = new List<UsersFavorites>();

        public DateTime CreatedOn { get; set; }
    }
}
