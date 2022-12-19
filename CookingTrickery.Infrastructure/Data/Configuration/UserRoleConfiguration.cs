using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            //    builder.HasData(new IdentityUserRole<string>
            //    {
            //        RoleId = "d2b7fd6f-b310-47af-8669-0517e64ac4b6",
            //        UserId = "0093ae6c-d848-43bf-bc62-01c5e684f4a4"
            //    });
        }
    }
}
