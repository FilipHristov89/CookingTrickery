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
        public DbSet<UserRecipe> UserRecipes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<IngredientMeasurement>()
                .HasKey(im => new { im.IngredientId, im.MeasurementId });

            builder
                .Entity<UserRecipe>()
                .HasKey(ur => new { ur.UserId, ur.RecipeId });

            builder
                .Entity<IngredientMeasurement>()
                .HasOne(im => im.Recipe)
                .WithMany(im => im.Ingredients)
                .HasForeignKey(im => im.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(UserUserNameMaxLength)
                .IsRequired();

            builder
                .Entity<User>()
                .HasOne(u => u.FavoriteCuisine)
                .WithMany(fc => fc.UsersFavorites)
                .HasForeignKey(u => u.FavoriteCuisineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<User>()
                .HasOne(u => u.FavoriteRecipe)
                .WithMany(fr => fr.UsersFavorites)
                .HasForeignKey(u => u.FavoriteRecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.
                Entity<User>()
               .Property(u => u.Email)
               .HasMaxLength(UserEmailMaxLenght)
               .IsRequired();


            base.OnModelCreating(builder);
        }
    }
}