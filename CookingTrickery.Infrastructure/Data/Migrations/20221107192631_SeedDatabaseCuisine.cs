using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class SeedDatabaseCuisine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cuisines_FavoriteCuisineId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientMeasurements_Recipes_RecipeId",
                table: "IngredientMeasurements");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Cuisines_CuisineId",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FavoriteCuisineId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0093ae6c-d848-43bf-bc62-01c5e684f4a4", 0, "1ff89448-298d-4325-9c97-7cc25d0f0e8d", "User", "f.g.hristov@gmail.com", false, null, "Filip", "Hristov", false, null, "F.G.HRISTOV@GMAIL.COM", "FROZSTY", "AQAAAAEAACcQAAAAEOOxYnuDR5IW62hC+rtPUlKNTqd17xrib/0nnYSKRvhPDr/gzmmBKM6idI0PpTDFTg==", null, false, "a384d933-4a04-434b-855f-0be0a98bd357", false, "Frozsty" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FavoriteCuisineId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bc60d5f7-3884-42c6-9fb5-e1db55094536", 0, "427386a4-f835-4785-8c36-58ef3acc39e6", "User", "guest@gmail.com", false, null, "Petar", "Petrov", false, null, "GUEST@GMAIL.COM", "GUEST", "AQAAAAEAACcQAAAAEDj7H/ZnD3we4I8LVJH1UkRNPOiNg2WXi0fSO6yjcGdZdcmfVtMHnwFqfZGnt7XfsA==", null, false, "864742a0-6945-4a3f-bf67-fb342df787d5", false, "Guest" });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cuisines_FavoriteCuisineId",
                table: "AspNetUsers",
                column: "FavoriteCuisineId",
                principalTable: "Cuisines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientMeasurements_Recipes_RecipeId",
                table: "IngredientMeasurements",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Cuisines_CuisineId",
                table: "Recipes",
                column: "CuisineId",
                principalTable: "Cuisines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Cuisines_FavoriteCuisineId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientMeasurements_Recipes_RecipeId",
                table: "IngredientMeasurements");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Cuisines_CuisineId",
                table: "Recipes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Cuisines_FavoriteCuisineId",
                table: "AspNetUsers",
                column: "FavoriteCuisineId",
                principalTable: "Cuisines",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientMeasurements_Recipes_RecipeId",
                table: "IngredientMeasurements",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Cuisines_CuisineId",
                table: "Recipes",
                column: "CuisineId",
                principalTable: "Cuisines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
