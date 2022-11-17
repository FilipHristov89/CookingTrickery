using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Core.Models.Cuisines
{
    public class CuisinePreviewViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
