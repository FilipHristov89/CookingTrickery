using CookingTrickery.Core.Models.Recipe;

namespace CookingTrickery.Core.Models.Cuisines
{
    public class CuisineViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string Description { get; set; } = null!;

        public IEnumerable<RecipePreviewViewModel> CuisineRecipe { get; set; } = new List<RecipePreviewViewModel>();

    }
}
