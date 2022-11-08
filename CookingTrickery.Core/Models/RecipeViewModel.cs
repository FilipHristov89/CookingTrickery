using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Models
{
    public class RecipeViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string QuickDescription { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        //public string Ingredients { get; set; } = null!;

        //public double Quantity { get; set; }

        //public string Measurement { get; set; } = null!;

        public string Cuisine { get; set; } = null!;

        public int NumberOfServings { get; set; }

        public string PrepTime { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string User { get; set; } = null!;
    }
}
