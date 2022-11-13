namespace CookingTrickery.Infrastructure.Data.Entities
{
    using CookingTrickery.Infrastructure.Data.Common;
    using System.ComponentModel.DataAnnotations;

    using static Data.Common.Constants.IngredientConstants;

    public class Ingredient
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(IngredientNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public IngredientTypeEnum Type { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        [MaxLength(IngredientDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(IngredientOriginMaxLength)]
        public string Origin { get; set; } = null!;

        public ICollection<IngredientMeasurement> IngredientsMeasurements { get; set; } = new List<IngredientMeasurement>();
    }
}
