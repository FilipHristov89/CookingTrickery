using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class AddRecipePicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e37d294c-b340-4e4f-b86f-278d52a56cd2", "AQAAAAEAACcQAAAAELyjQsAdax6M2KaZYk2T6Mz4pEq888umNOFXL7u6Dva+JvptaFwtWWxCJ3bhqyPE3Q==", "48756312-5c2e-473b-8f07-f06ae2226099" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a10289f9-5be2-493f-bfaf-d5eed90809a6", "AQAAAAEAACcQAAAAEIVFu4CY/qbnsVrRzsUeYtI7S4AVNLuvpDQt64uv6aqDTp2QJn8N7pVR3+XklrvtSQ==", "a3513ee8-d93c-4536-88b4-a12078a8eb81" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"),
                columns: new[] { "CreatedOn", "ImageUrl" },
                values: new object[] { new DateTime(2022, 11, 8, 19, 28, 27, 759, DateTimeKind.Local).AddTicks(9875), "https://s23209.pcdn.co/wp-content/uploads/2016/10/221024_DD_Slow-Cooker-Beef-Stew_218-760x1140.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Recipes");

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
        }
    }
}
