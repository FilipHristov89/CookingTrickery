using CookingTrickery.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Models.Ingredients
{
    public class IngredientPreviewViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public IngredientTypeEnum Type { get; set; }

        public string Origin { get; set; } = null!;

        public int Calories { get; set; }
    }
}
