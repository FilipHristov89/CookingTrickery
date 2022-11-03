using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static CookingTrickery.Infrastructure.Data.Common.Constants.UserConstants;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            UserRelations(builder);
        }

        private static void UserRelations(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(u => u.UserName)
                .HasMaxLength(UserUserNameMaxLength)
                .IsRequired();

            builder
                .HasOne(u => u.FavoriteCuisine)
                .WithMany(fc => fc.UsersFavorites)
                .HasForeignKey(u => u.FavoriteCuisineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.FavoriteRecipe)
                .WithMany(fr => fr.UsersFavorites)
                .HasForeignKey(u => u.FavoriteRecipeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Property(u => u.Email)
               .HasMaxLength(UserEmailMaxLenght)
               .IsRequired();

        }
    }
}
