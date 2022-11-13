using CookingTrickery.Infrastructure.Data.Common;
using System.ComponentModel.DataAnnotations;

using static CookingTrickery.Infrastructure.Data.Common.Constants.IngredientConstants;

namespace CookingTrickery.Core.Models.Ingredients
{
    public class CreateIngredientViewModel
    {
        [Required]
        [StringLength(IngredientNameMaxLength, MinimumLength = IngredientNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public IngredientTypeEnum Type { get; set; }

        [Required]
        [StringLength(IngredientDescriptionMaxLength, MinimumLength = IngredientDescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int Calories { get; set; }

        [Required]
        [StringLength(IngredientOriginMaxLength, MinimumLength = IngredientOriginMinLength)]
        public string Origin { get; set; } = null!;
    }
}
