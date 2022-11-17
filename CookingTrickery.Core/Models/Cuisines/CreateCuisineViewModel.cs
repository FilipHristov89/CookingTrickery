using System.ComponentModel.DataAnnotations;

using static CookingTrickery.Infrastructure.Data.Common.Constants.CuisineConstants;

namespace CookingTrickery.Core.Models.Cuisines
{
    public class CreateCuisineViewModel
    {
        [Required]
        [MaxLength(CuisineNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(CuisineDescriptionMaxLength)]
        public string Description { get; set; } = null!;
    }
}
