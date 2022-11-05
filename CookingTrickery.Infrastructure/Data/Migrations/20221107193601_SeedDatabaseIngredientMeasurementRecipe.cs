using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class SeedDatabaseIngredientMeasurementRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientMeasurements_Recipes_RecipeId",
                table: "IngredientMeasurements");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Cuisines_CuisineId",
                table: "Recipes");

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

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CreatedOn", "CuisineId", "Description", "Name", "NumberOfServing", "PrepTime", "QuickDescription", "Rating", "UserId" },
                values: new object[] { new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"), new DateTime(2022, 11, 7, 21, 36, 1, 70, DateTimeKind.Local).AddTicks(1848), new Guid("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"), "Heat olive oil in a large cast iron skillet over medium heat.Season beef with salt and pepper, to taste. Add beef to the skillet and cook until evenly browned, about 2-3 minutes.Place beef, potatoes, carrots, onion and garlic into a 6-qt slow cooker. Stir in beef broth, tomato paste, Worcestershire, thyme, rosemary, paprika, caraway seeds and bay leaves until well combined; season with salt and pepper, to taste.Cover and cook on low heat for 7-8 hours or high heat for 3-4 hours.In a small bowl, whisk together flour and 1/2 cup stew broth. Stir in flour mixture into the slow cooker. Cover and cook on high heat for an additional 30 minutes, or until thickened.Serve immediately, garnished with parsley, if desired.", "Slow Cooked Beef Stew", 4, "8 hours", "Everyone’s favorite cozy beef stew made in the crockpot! The meat is SO TENDER and the stew is rich", null, "0093ae6c-d848-43bf-bc62-01c5e684f4a4" });

            migrationBuilder.InsertData(
                table: "IngredientMeasurements",
                columns: new[] { "IngredientId", "MeasurementId", "Id", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"), new Guid("27c6be3e-3404-4525-9a05-b3b4811ad2dd"), new Guid("83674210-f4dd-45d6-bafd-08d0c41cd377"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"), new Guid("bb9b314b-faa4-4e3b-ac45-b0fd25aa987c"), new Guid("6aa10633-e0b0-4fe7-b51b-648ec0317eb7"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"), new Guid("dec7d41c-542f-41be-8ca4-e95aaa5a1fdd"), new Guid("f2cf0b9e-5833-4e35-a702-4a9fbf894fe0"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("39af066a-8e5b-4942-bd68-932714284d66"), new Guid("451e6845-3dde-44fa-9787-37d2f12fab0b"), new Guid("b4ab7081-66da-4475-b74c-fe884afdaf70"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"), new Guid("b5a9d637-315c-416b-98f9-ee5f702833de"), new Guid("910a86d1-d35e-423a-b987-7a7650f24087"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"), new Guid("df4924db-cdc2-44f4-9ab0-b181c26c5e93"), new Guid("8b6883eb-c59b-4ea3-b295-9e9de6881961"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"), new Guid("c2106501-d1ce-4eb0-9c91-82a4898fcb67"), new Guid("9e8902ca-1b4d-4cf1-ac7a-10bbd83e0b41"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("551e0516-e39a-4359-8211-d97e4152abcc"), new Guid("77264a66-b4a2-4657-abf7-9db4e7b1adf9"), new Guid("1b35c331-ed11-4b77-8f3e-05bf7ab96514"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"), new Guid("fadac7a7-abb2-4e75-93f4-b42ac441bed5"), new Guid("b39e2204-0651-487c-8192-da80bdab12de"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"), new Guid("a6cd1e21-4010-4bfc-8b31-be5776aa2a7a"), new Guid("6a26c5ae-76d0-4c62-bf05-099c6c91cadc"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") },
                    { new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"), new Guid("8b1d8496-58a3-405f-8bc2-036867407274"), new Guid("b7741e3d-743b-4aef-b20d-c6a81596ae83"), new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f") }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientMeasurements_Recipes_RecipeId",
                table: "IngredientMeasurements");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_UserId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Cuisines_CuisineId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientMeasurements",
                table: "IngredientMeasurements");

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("0f09aa47-294d-44d4-a0a4-a275ea55e6bc"), new Guid("27c6be3e-3404-4525-9a05-b3b4811ad2dd") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("28aeedac-d707-4ae8-8404-fcf89a3719a3"), new Guid("bb9b314b-faa4-4e3b-ac45-b0fd25aa987c") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("36d126d9-e4ae-47e7-ac09-937e0a8ebf6d"), new Guid("dec7d41c-542f-41be-8ca4-e95aaa5a1fdd") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("39af066a-8e5b-4942-bd68-932714284d66"), new Guid("451e6845-3dde-44fa-9787-37d2f12fab0b") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("3a48aa8a-d9a3-43f5-bc8b-d98d1515ec43"), new Guid("b5a9d637-315c-416b-98f9-ee5f702833de") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("3ea505ff-7e9a-4540-8100-182123ce9605"), new Guid("df4924db-cdc2-44f4-9ab0-b181c26c5e93") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("485c2be4-8417-4ed1-90b6-467cbce9d46a"), new Guid("c2106501-d1ce-4eb0-9c91-82a4898fcb67") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("551e0516-e39a-4359-8211-d97e4152abcc"), new Guid("77264a66-b4a2-4657-abf7-9db4e7b1adf9") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("6e56c040-63ec-4fa8-9c87-ba3a1a732a22"), new Guid("fadac7a7-abb2-4e75-93f4-b42ac441bed5") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("9752dbe2-cf14-4393-bbd7-f28fa6ff617b"), new Guid("a6cd1e21-4010-4bfc-8b31-be5776aa2a7a") });

            migrationBuilder.DeleteData(
                table: "IngredientMeasurements",
                keyColumns: new[] { "IngredientId", "MeasurementId" },
                keyValues: new object[] { new Guid("ca39cc0d-6b7c-4226-a912-80bd7a56e7e7"), new Guid("8b1d8496-58a3-405f-8bc2-036867407274") });

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("b169fcbd-cde5-4a5b-8ab7-258572d98f8f"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientMeasurements",
                table: "IngredientMeasurements",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0408113c-3bb2-4917-ace8-2508308007b2", "AQAAAAEAACcQAAAAEAyplOTeAaJunanvZ80HoslV0/axKvdBbF3iCnRiFCqBle51eaGfv3j6V0JG0GQ4iw==", "1e37dcc9-497f-4491-b963-fef4a834687e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef270461-6e7c-496d-8f61-464c05adaf6a", "AQAAAAEAACcQAAAAEPardH3+JJRXXeG6rDLkUTu2d+rKKuBDP6E054nktEnRUw5vdkLNmJqsQkxJ0FNF2g==", "a8152185-51f6-4f83-b5ec-5277228064bd" });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientMeasurements_IngredientId",
                table: "IngredientMeasurements",
                column: "IngredientId");

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
    }
}
