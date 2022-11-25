namespace CookingTrickery.Core.Models.Ingredients
{
    public  class IngredientQueryModel
    {
        public int TotalIngredientsCount { get; set; }

        public IEnumerable<IngredientPreviewViewModel> Ingredients { get; set; } = new List<IngredientPreviewViewModel>();
    }
}
