namespace CookingTrickery.Core.Models.Recipe
{
    public class RecipeViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string QuickDescription { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public ICollection<RecipeIngredientModel> Ingredients { get; set; } = new List<RecipeIngredientModel>();

        public string Cuisine { get; set; } = null!;

        public int NumberOfServings { get; set; }

        public string PrepTime { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string User { get; set; } = null!;
    }
}
