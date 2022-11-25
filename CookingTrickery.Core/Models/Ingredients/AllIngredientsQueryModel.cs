using CookingTrickery.Infrastructure.Data.Common;

namespace CookingTrickery.Core.Models.Ingredients
{
    public class AllIngredientsQueryModel
    {
        public string? IngredientName { get; set; }

        public string? IngredientOrigin { get; set; }

        public IngredientTypeEnum IngredientType { get; set; }

        public IngredientSorting Sorting { get; set; }

        public int TotalIngredientsCount { get; set; }

        public IEnumerable<IngredientPreviewViewModel> Ingredients { get; set; } = Enumerable.Empty<IngredientPreviewViewModel>();
    }
}
