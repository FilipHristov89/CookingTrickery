using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using static CookingTrickery.Infrastructure.Data.Common.Constants.UserConstants;

namespace CookingTrickery.Infrastructure.Data.Entities
{
    public class User : IdentityUser
    {      
        [MaxLength(UserFirstNameMaxLenght)]
        public string FirstName { get; set; } = null!;

        [MaxLength(UserLastNameMaxLenght)]
        public string LastName { get; set; } = null!;

        public Guid? FavoriteCuisineId { get; set; }
        
        [ForeignKey(nameof(FavoriteCuisineId))]
        public Cuisine? FavoriteCuisine { get; set; } = null!;

        public ICollection<Recipe> UserRecipes { get; set; } = new List<Recipe>();

        public ICollection<UsersFavorites> FavoriteRecipes { get; set; } = new List<UsersFavorites>();
    }
}
