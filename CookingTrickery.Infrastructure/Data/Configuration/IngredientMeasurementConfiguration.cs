using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class IngredientMeasurementConfiguration : IEntityTypeConfiguration<IngredientMeasurement>
    {
        public void Configure(EntityTypeBuilder<IngredientMeasurement> builder)
        {
            IngredientMeasurementRelations(builder);
            builder.HasData(SeedIngredientMeasurements());
        }

        private void IngredientMeasurementRelations(EntityTypeBuilder<IngredientMeasurement> builder)
        {
            builder.HasOne(im => im.Ingredient)
                .WithMany(i => i.IngredientsMeasurements)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(im => im.Measurement)
                .WithMany(m => m.IngredientsMeasurements)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private List<IngredientMeasurement> SeedIngredientMeasurements()
        {
            List<IngredientMeasurement> ingredients = new List<IngredientMeasurement>()
            {
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("8b6883eb-c59b-4ea3-b295-9e9de6881961"),
                    IngredientId = Guid.Parse("3ea505ff-7e9a-4540-8100-182123ce9605"),
                    MeasurementId = Guid.Parse("df4924db-cdc2-44f4-9ab0-b181c26c5e93"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("83674210-f4dd-45d6-bafd-08d0c41cd377"),
                    IngredientId = Guid.Parse("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"),
                    MeasurementId = Guid.Parse("27c6be3e-3404-4525-9a05-b3b4811ad2dd"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("6a26c5ae-76d0-4c62-bf05-099c6c91cadc"),
                    IngredientId = Guid.Parse("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"),
                    MeasurementId = Guid.Parse("a6cd1e21-4010-4bfc-8b31-be5776aa2a7a"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = new Guid("9e8902ca-1b4d-4cf1-ac7a-10bbd83e0b41"),
                    IngredientId = Guid.Parse("485c2be4-8417-4ed1-90b6-467cbce9d46a"),
                    MeasurementId = Guid.Parse("c2106501-d1ce-4eb0-9c91-82a4898fcb67"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("f2cf0b9e-5833-4e35-a702-4a9fbf894fe0"),
                    IngredientId = Guid.Parse("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"),
                    MeasurementId = Guid.Parse("dec7d41c-542f-41be-8ca4-e95aaa5a1fdd"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("b7741e3d-743b-4aef-b20d-c6a81596ae83"),
                    IngredientId = Guid.Parse("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"),
                    MeasurementId = Guid.Parse("8b1d8496-58a3-405f-8bc2-036867407274"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("b4ab7081-66da-4475-b74c-fe884afdaf70"),
                    IngredientId = Guid.Parse("39af066a-8e5b-4942-bd68-932714284d66"),
                    MeasurementId = Guid.Parse("451e6845-3dde-44fa-9787-37d2f12fab0b"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("6aa10633-e0b0-4fe7-b51b-648ec0317eb7"),
                    IngredientId = Guid.Parse("28aeedac-d707-4ae8-8404-fcf89a3719a3"),
                    MeasurementId = Guid.Parse("bb9b314b-faa4-4e3b-ac45-b0fd25aa987c"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("1b35c331-ed11-4b77-8f3e-05bf7ab96514"),
                    IngredientId = Guid.Parse("551e0516-e39a-4359-8211-d97e4152abcc"),
                    MeasurementId = Guid.Parse("77264a66-b4a2-4657-abf7-9db4e7b1adf9"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {   
                    Id = Guid.Parse("910a86d1-d35e-423a-b987-7a7650f24087"),
                    IngredientId = Guid.Parse("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"),
                    MeasurementId = Guid.Parse("b5a9d637-315c-416b-98f9-ee5f702833de"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                },
                new IngredientMeasurement()
                {
                    Id = Guid.Parse("b39e2204-0651-487c-8192-da80bdab12de"),
                    IngredientId = Guid.Parse("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"),
                    MeasurementId = Guid.Parse("fadac7a7-abb2-4e75-93f4-b42ac441bed5"),
                    RecipeId = Guid.Parse("b169fcbd-cde5-4a5b-8ab7-258572d98f8f")
                }
            };

            return ingredients;
        }
    }
}
