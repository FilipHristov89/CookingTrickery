namespace CookingTrickery.Core.Models.Recipe
{
    public class RecipePreviewViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string QuickDescription { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string? Cuisine { get; set; }

        public string User { get; set; } = null!;
    }
}
