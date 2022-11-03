using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class UserRecipeConfiguration : IEntityTypeConfiguration<UserRecipe>
    {
        public void Configure(EntityTypeBuilder<UserRecipe> builder)
        {
            builder
                .HasKey(ur => new { ur.UserId, ur.RecipeId });
        }
    }
}
