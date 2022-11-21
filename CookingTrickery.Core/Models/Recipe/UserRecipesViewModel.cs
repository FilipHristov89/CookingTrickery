using CookingTrickery.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Models.Recipe
{
    public class UserRecipesViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string QuickDescription { get; set; } = null!;

        public Guid? CuisineId { get; set; }
        public string? Cuisine { get; set; }

    }
}
