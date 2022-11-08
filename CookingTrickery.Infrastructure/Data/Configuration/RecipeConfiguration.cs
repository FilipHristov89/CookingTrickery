using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            RecipeRelations(builder);
            builder.HasData(RecipeSeed());
        }

        private static void RecipeRelations(EntityTypeBuilder<Recipe> builder)
        {
            builder
                .HasMany(r => r.Ingredients)
                .WithOne(i => i.Recipe)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.Cuisine)
                .WithMany(r => r.Recipes)
                .HasForeignKey(r => r.CuisineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.User)
                .WithMany(u => u.UserRecipes)
                .OnDelete(DeleteBehavior.NoAction);

        }

        private List<Recipe> RecipeSeed()
        {
            var recipes = new List<Recipe>
            {
                new Recipe()
                {
                    Id = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                    Name = "Slow Cooked Beef Stew",
                    QuickDescription = "Everyone’s favorite cozy beef stew made in the crockpot! The meat is SO TENDER and the stew is rich",
                    Description = "Heat olive oil in a large cast iron skillet over medium heat.Season beef with salt and pepper, to taste. Add beef to the skillet and cook until evenly browned, about 2-3 minutes.Place beef, potatoes, carrots, onion and garlic into a 6-qt slow cooker. Stir in beef broth, tomato paste, Worcestershire, thyme, rosemary, paprika, caraway seeds and bay leaves until well combined; season with salt and pepper, to taste.Cover and cook on low heat for 7-8 hours or high heat for 3-4 hours.In a small bowl, whisk together flour and 1/2 cup stew broth. Stir in flour mixture into the slow cooker. Cover and cook on high heat for an additional 30 minutes, or until thickened.Serve immediately, garnished with parsley, if desired.",
                    PrepTime = "8 hours",
                    CuisineId = Guid.Parse("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"),
                    NumberOfServing = 4,
                    CreatedOn = DateTime.Now.ToLocalTime(),
                    UserId = "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                    ImageUrl = "https://s23209.pcdn.co/wp-content/uploads/2016/10/221024_DD_Slow-Cooker-Beef-Stew_218-760x1140.jpg"

                }
            };

            return recipes;
        }
    }
}
