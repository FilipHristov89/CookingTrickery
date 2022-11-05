using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class IgredientMeasurementKeyFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientMeasurements",
                table: "IngredientMeasurements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientMeasurements",
                table: "IngredientMeasurements",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "641e8adc-5075-4752-98c6-443a7f189c58", "AQAAAAEAACcQAAAAELYEOrvRk0/2k8agvVg8s+Y9wHdYlN2vZyrlFZhpUjlCTrVaH7OnbJQCGO53QNAvyA==", "2949165c-9fea-4191-bb70-4a18a2062593" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4213d3a-ab3b-4e5f-aea9-3c9a6a6e2468", "AQAAAAEAACcQAAAAEOa2JXSGVrtNh5oRUWVqT6ZxgI+bIy/CiEUQfIF9nxdCyIm2a1IdbPi0Byqa1Gm6/w==", "718e8641-78a2-4c93-82ae-98a899de8447" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 7, 21, 55, 51, 677, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.CreateIndex(
                name: "IX_IngredientMeasurements_IngredientId",
                table: "IngredientMeasurements",
                column: "IngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientMeasurements",
                table: "IngredientMeasurements");

            migrationBuilder.DropIndex(
                name: "IX_IngredientMeasurements_IngredientId",
                table: "IngredientMeasurements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientMeasurements",
                table: "IngredientMeasurements",
                columns: new[] { "IngredientId", "MeasurementId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37c2d3d4-91e2-43cc-a175-f2e0e6bbdc32", "AQAAAAEAACcQAAAAEBmHsrUAQkd7k5OoG3U0eFXDQaEXCKjUrbvgwjpEbReOfPsM+pgIS9xRrn/7LQ6lLw==", "e7e24af4-e9e7-4c0a-a594-443b843e4c80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7c4d365-c8c8-4a1e-8aaa-ee41d23ec11a", "AQAAAAEAACcQAAAAEPV2C9yXVG/ypRQvZ3THPjqpPyciFUPenAGOVykyCY4Xc1b1+2/+ZaICs14GeyLqYw==", "c0d83a35-6ec2-46ff-a430-1c352ee8d5b7" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                column: "CreatedOn",
                value: new DateTime(2022, 11, 7, 21, 36, 1, 70, DateTimeKind.Local).AddTicks(1848));
        }
    }
}
