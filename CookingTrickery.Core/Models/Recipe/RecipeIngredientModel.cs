namespace CookingTrickery.Core.Models.Recipe
{
    public class RecipeIngredientModel
    {
        public string Ingredient { get; set; } = null!;

        public double Quantity { get; set; }

        public string Measurement { get; set; } = null!;
    }
}
