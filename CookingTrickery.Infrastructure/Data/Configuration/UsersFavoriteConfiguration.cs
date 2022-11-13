using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class UsersFavoriteConfiguration : IEntityTypeConfiguration<UsersFavorites>
    {
        public void Configure(EntityTypeBuilder<UsersFavorites> builder)
        {
            builder
                .HasKey(ur => new { ur.UserId, ur.RecipeId });
        }
    }
}
