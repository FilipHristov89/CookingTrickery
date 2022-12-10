using CookingTrickery.Infrastructure.Data.Configuration;
using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using static CookingTrickery.Infrastructure.Data.Common.Constants.UserConstants;

namespace CookingTrickery.Infrastructure.Data
{
    public class CookingTrickeryDbContext : IdentityDbContext
    {
        //private User masterUser { get; set; }
        public CookingTrickeryDbContext(DbContextOptions<CookingTrickeryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<Measurement> Measurements { get; set; } = null!;
        public DbSet<Cuisine> Cuisines { get; set; } = null!;
        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<IngredientMeasurement> IngredientMeasurements { get; set; } = null!;
        public DbSet<UsersFavorites> UserRecipes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new IngredientMeasurementConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new RecipeConfiguration());
            builder.ApplyConfiguration(new IngredientConfiguration());
            builder.ApplyConfiguration(new MeasurementConfiguration());
            builder.ApplyConfiguration(new CuisineConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UsersFavoriteConfiguration());

            base.OnModelCreating(builder);
        }
    }
}