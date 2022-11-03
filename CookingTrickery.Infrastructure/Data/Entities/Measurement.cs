namespace CookingTrickery.Infrastructure.Data.Entities
{
    using CookingTrickery.Infrastructure.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class Measurement
    {
        public Guid Id { get; set; }

        public double Quantity { get; set; }

        [Required]
        public MeasurementTypeEnum MeasurementType { get; set; }

        public ICollection<IngredientMeasurement> IngredientsMeasurements { get; set; } = new List<IngredientMeasurement>();
    }
}
