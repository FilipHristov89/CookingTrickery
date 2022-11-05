using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
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
            builder.HasData(UserSeed());
        }

        private static void UserRelations(EntityTypeBuilder<User> builder)
        {
            builder
                .Property(u => u.UserName)
                .HasMaxLength(UserUserNameMaxLength)
                .IsRequired();

            builder
                .HasMany(u => u.UserRecipes)
                .WithOne(ur => ur.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.FavoriteCuisine)
                .WithMany(fc => fc.UsersFavorites)
                .HasForeignKey(u => u.FavoriteCuisineId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
               .Property(u => u.Email)
               .HasMaxLength(UserEmailMaxLenght)
               .IsRequired();

        }

        private List<User> UserSeed()
        {
            var users = new List<User>();
            var hasher = new PasswordHasher<User>();

            User masterUser = new User()
            {
                Id = "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                UserName = "Frozsty",
                Email = "f.g.hristov@gmail.com",
                FirstName = "Filip",
                LastName = "Hristov",
                NormalizedUserName = "FROZSTY",
                NormalizedEmail = "F.G.HRISTOV@GMAIL.COM",
            };

            masterUser.PasswordHash = hasher.HashPassword(masterUser, "Fikata1!");

            User guestUser = new User()
            {
                Id = "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                UserName = "Guest",
                Email = "guest@gmail.com",
                FirstName = "Petar",
                LastName = "Petrov",
                NormalizedUserName = "GUEST",
                NormalizedEmail = "GUEST@GMAIL.COM"
            };
            guestUser.PasswordHash = hasher.HashPassword(guestUser, "Guest1!");

            users.Add(masterUser);
            users.Add(guestUser);

            return users;
        }
    }
}
