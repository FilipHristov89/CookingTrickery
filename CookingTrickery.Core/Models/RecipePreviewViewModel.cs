﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Models
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
