//using CookingTrickery.Infrastructure.Data.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace CookingTrickery.Infrastructure.Data.Configuration
//{
//    internal class IngredientMeasurementConfiguration : IEntityTypeConfiguration<IngredientMeasurement>
//    {
//        private ModelBuilder modelBuilder;
//        public void Configure(EntityTypeBuilder<IngredientMeasurement> builder)
//        {
//            IngredientMeasurementRelations(modelBuilder);
//        }

//        private static void IngredientMeasurementRelations(ModelBuilder modelBuilder)
//        {
//            modelBuilder
//                .Entity<IngredientMeasurement>()
//                .HasKey(im => new { im.IngredientId, im.MeasurementId });

//            modelBuilder
//                .Entity<IngredientMeasurement>()
//                .HasOne(im => im.Recipe)
//                .WithMany(im => im.Ingredients)
//                .HasForeignKey(im => im.RecipeId)
//                .OnDelete(DeleteBehavior.Restrict);
//        }
//    }
//}
