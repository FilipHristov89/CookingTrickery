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

        public List<IngredientMeasurement> Ingredients { get; set; } = new List<IngredientMeasurement>();
        
        public Guid CuisineId { get; set; }
        [ForeignKey(nameof(CuisineId))]
        public Cuisine? Cuisine { get; set; }

        [Required]
        [MaxLength(RecipeDescriptionMaxLenght)]
        public string Description { get; set; } = null!;

        public int NumberOfServing { get; set; }

        public double PrepTime { get; set; }

        public double? Rating { get; set; }

        public ICollection<UserRecipe> UsersRecipes { get; set; } = new List<UserRecipe>();

        public ICollection<User> UsersFavorites { get; set; } = new List<User>();
    }
}
