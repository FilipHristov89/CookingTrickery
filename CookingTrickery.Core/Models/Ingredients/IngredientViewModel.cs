using CookingTrickery.Core.Models.Recipe;

namespace CookingTrickery.Core.Models.Ingredients
{
    public class IngredientViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Type { get; set; } = null!;

        public int Calories { get; set; }

        public string Origin { get; set; } = null!;

        public string Description { get; set; } = null!;

        public IEnumerable<RecipePreviewViewModel> IngredientRecipe { get; set; } = new List<RecipePreviewViewModel>();
    }
}
