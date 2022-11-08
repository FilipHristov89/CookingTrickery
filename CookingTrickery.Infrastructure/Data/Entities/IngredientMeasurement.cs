using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookingTrickery.Infrastructure.Data.Entities
{
    public class IngredientMeasurement
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid IngredientId { get; set; }
        [ForeignKey(nameof(IngredientId))]
        public Ingredient Ingredient { get; set; } = null!;

        [Required]
        public Guid MeasurementId { get; set; }
        [ForeignKey(nameof(MeasurementId))]
        public Measurement Measurement { get; set; } = null!;

        [Required]
        public Guid RecipeId { get; set; }
        [ForeignKey(nameof(RecipeId))]
        public Recipe Recipe { get; set; } = null!;
    }
}
