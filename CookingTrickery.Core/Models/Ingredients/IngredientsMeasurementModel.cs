using CookingTrickery.Infrastructure.Data.Entities;
using System.Reflection.Metadata.Ecma335;

namespace CookingTrickery.Core.Models.Ingredients
{
    public class IngredientsMeasurementModel
    {

        public Guid IngredientId { get; set; }

        public double Quantity { get; set; }

        public int Measurement { get; set; }
    }
}
