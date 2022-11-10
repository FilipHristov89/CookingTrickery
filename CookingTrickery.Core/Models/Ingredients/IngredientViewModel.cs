using Microsoft.Build.Evaluation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
