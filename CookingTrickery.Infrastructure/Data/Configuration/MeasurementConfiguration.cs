using CookingTrickery.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static CookingTrickery.Infrastructure.Data.Common.MeasurementTypeEnum;

namespace CookingTrickery.Infrastructure.Data.Configuration
{
    internal class MeasurementConfiguration : IEntityTypeConfiguration<Measurement>
    {
        public void Configure(EntityTypeBuilder<Measurement> builder)
        {
            //builder.HasData(MeasurementsSeed());
        }

        private List<Measurement> MeasurementsSeed()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement()
                {
                    Id = new Guid("fadac7a7-abb2-4e75-93f4-b42ac441bed5"),
                    Quantity = 2,
                    MeasurementType = tbsp
                },
                new Measurement()
                {
                    Id = new Guid("dec7d41c-542f-41be-8ca4-e95aaa5a1fdd"),
                    Quantity = 2,
                    MeasurementType = lb
                },
                new Measurement()
                {
                    Id = Guid.Parse("c2106501-d1ce-4eb0-9c91-82a4898fcb67"),
                    Quantity = 1,
                    MeasurementType = lb
                },
                new Measurement()
                {
                    Id = new Guid("27c6be3e-3404-4525-9a05-b3b4811ad2dd"),
                    Quantity = 4,
                    MeasurementType = piece
                },
                new Measurement()
                {
                    Id = new Guid("df4924db-cdc2-44f4-9ab0-b181c26c5e93"),
                    Quantity = 1,
                    MeasurementType = piece
                },
                new Measurement()
                {
                    Id = new Guid("a6cd1e21-4010-4bfc-8b31-be5776aa2a7a"),
                    Quantity = 3,
                    MeasurementType = cloves
                },
                new Measurement()
                {
                    Id = new Guid("100248f5-ce7f-40ca-abc8-c0d005c8a988"),
                    Quantity = 3,
                    MeasurementType = cups
                },
                new Measurement()
                {
                    Id = new Guid("bb9b314b-faa4-4e3b-ac45-b0fd25aa987c"),
                    Quantity = 2,
                    MeasurementType = tbsp
                },
                new Measurement()
                {
                    Id = Guid.Parse("451e6845-3dde-44fa-9787-37d2f12fab0b"),
                    Quantity = 1,
                    MeasurementType = tbsp
                },
                new Measurement()
                {
                    Id = new Guid("77264a66-b4a2-4657-abf7-9db4e7b1adf9"),
                    Quantity = 1,
                    MeasurementType = tsp
                },
                new Measurement()
                {
                    Id = new Guid("b5a9d637-315c-416b-98f9-ee5f702833de"),
                    Quantity = 1,
                    MeasurementType = tsp
                },
                new Measurement()
                {
                    Id = new Guid("63cd695b-d2fc-42b7-9e1c-633e1dcec351"),
                    Quantity = 1,
                    MeasurementType = tsp
                },
                new Measurement()
                {
                    Id = new Guid("8b1d8496-58a3-405f-8bc2-036867407274"),
                    Quantity = 1,
                    MeasurementType = tsp
                },
                new Measurement()
                {
                    Id = new Guid("717496fb-5b3c-439f-bc15-dd74381d6d7d"),
                    Quantity = 2,
                    MeasurementType = pieces
                },
                new Measurement()
                {
                    Id = new Guid("1ac5b1b6-9dbb-49fc-ad95-686476a0fb57"),
                    Quantity = 0.5,
                    MeasurementType = cup
                },
                new Measurement()
                {
                    Id = new Guid("d45f0662-ae2e-47ce-b662-8e459b3f0e0e"),
                    Quantity = 2,
                    MeasurementType = tbsp
                },
            };

            return measurements;
        }
    }
}
