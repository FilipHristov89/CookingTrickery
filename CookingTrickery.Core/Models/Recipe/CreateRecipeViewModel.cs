using CookingTrickery.Infrastructure.Data.Common;
using CookingTrickery.Infrastructure.Data.Entities;
using System.ComponentModel.DataAnnotations;

using static CookingTrickery.Infrastructure.Data.Common.Constants.RecipeConstants;
namespace CookingTrickery.Core.Models.Recipe
{
    public class CreateRecipeViewModel
    {
        [Required]
        [StringLength(RecipeNameMaxLength, MinimumLength = RecipeNameMinLength)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(RecipeQuickDescriptionMaxLength)]
        public string QuickDescription { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        public Guid IngredientId { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        [Required]
        public double Quantity { get; set; }

        [Required]
        public MeasurementTypeEnum Measurement { get; set; }

        [Required]
        [StringLength(RecipeDescriptionMaxLength, MinimumLength = RecipeDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int NumberOfServings { get; set; }

        public double? Rating { get; set; }
    }
}
