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
        }

        private static void IngredientMeasurementRelations(EntityTypeBuilder<IngredientMeasurement> builder)
        {
            builder
                .HasKey(im => new { im.IngredientId, im.MeasurementId });

            builder
                .HasOne(im => im.Recipe)
                .WithMany(im => im.Ingredients)
                .HasForeignKey(im => im.RecipeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
