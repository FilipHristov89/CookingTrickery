using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Id = "d2b7fd6f-b310-47af-8669-0517e64ac4b6",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR".ToUpper(),
                ConcurrencyStamp = "974f5276-0850-4225-a6dd-eaca17b9fbe7"
            });

        }
    }
}
