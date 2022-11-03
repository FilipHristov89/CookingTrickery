//using CookingTrickery.Infrastructure.Data.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//using static CookingTrickery.Infrastructure.Data.Common.Constants.UserConstants;

//namespace CookingTrickery.Infrastructure.Data.Configuration
//{
//    internal class UserConfiguration : IEntityTypeConfiguration<User>
//    {
//        private ModelBuilder modelBuilder;

//        public void Configure(EntityTypeBuilder<User> builder)
//        {
//            UserRelations(modelBuilder);
//        }

//        private static void UserRelations(ModelBuilder modelBuilder)
//        {
//            modelBuilder
//                .Entity<User>()
//                .Property(u => u.UserName)
//                .HasMaxLength(UserUserNameMaxLength)
//                .IsRequired();

//            modelBuilder
//                .Entity<User>()
//                .HasOne(u => u.FavoriteCuisine)
//                .WithMany(fc => fc.UsersFavorites)
//                .HasForeignKey(u => u.FavoriteCuisineId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder
//                .Entity<User>()
//                .HasOne(u => u.FavoriteRecipe)
//                .WithMany(fr => fr.UsersFavorites)
//                .HasForeignKey(u => u.FavoriteRecipeId)
//                .OnDelete(DeleteBehavior.Restrict);

//            modelBuilder.
//                Entity<User>()
//               .Property(u => u.Email)
//               .HasMaxLength(UserEmailMaxLenght)
//               .IsRequired();

//            modelBuilder
//                .Entity<UserRecipe>()
//                .HasKey(ur => new { ur.UserId, ur.RecipeId });
//        }
//    }
//}
