namespace CookingTrickery.Core.Models.Ingredients
{
    public class IngredientByTypeViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Type { get; set; } = null!;

    }
}
