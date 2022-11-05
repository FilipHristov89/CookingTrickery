using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class SeedDatabaseCuisineRedo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("a6521833-8514-4d09-b7c0-9ee03373ffc5"), "Bulgarian cuisine is a representative of the cuisine of Southeast Europe. It shares characteristics with other Balkan cuisines. Bulgarian cooking traditions are diverse because of geographical factors such as climatic conditions suitable for a variety of vegetables, herbs, and fruit. Aside from the vast variety of local Bulgarian dishes, Bulgarian cuisine shares a number of dishes with Persian, Turkish, and Greek cuisine.Bulgarian food often incorporates salads as appetizers and is also noted for the prominence of dairy products, wines and other alcoholic drinks such as rakia.", "Bulgarian Cuisine" },
                    { new Guid("b0de4591-35bc-4500-b84f-ee04c64775ea"), "Mexican cuisine consists of the cooking cuisines and traditions of the modern country of Mexico. Its earliest roots lie in Mesoamerican cuisine. Its ingredients and methods begin with the first agricultural communities such as the Maya who domesticated maize, created the standard process of maize nixtamalization, and established their foodways (Maya cuisine). Successive waves of other Mesoamerican groups brought with them their own cooking methods. These included: the Olmec, Teotihuacanos, Toltec, Huastec, Zapotec, Mixtec, Otomi, Purépecha, Totonac, Mazatec, Mazahua, and Nahua. With the Mexica formation of the multi-ethnic Triple Alliance (Aztec Empire), culinary foodways became infused (Aztec cuisine).", "Mexican Cuisine" },
                    { new Guid("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"), "British cuisine is the specific set of cooking traditions and practices associated with the United Kingdom. Historically, British cuisine meant \"unfussy dishes made with quality local ingredients, matched with simple sauces to accentuate flavour, rather than disguise it\". International recognition of British cuisine was historically limited to the full breakfast and the Christmas dinner. However, Celtic agriculture and animal breeding produced a wide variety of foodstuffs for indigenous Celts. Anglo-Saxon England developed meat and savoury herb stewing techniques before the practice became common in Europe. The Norman conquest introduced exotic spices into Great Britain in the Middle Ages", "British Cuisine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: new Guid("a6521833-8514-4d09-b7c0-9ee03373ffc5"));

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: new Guid("b0de4591-35bc-4500-b84f-ee04c64775ea"));

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: new Guid("ff8540f2-e7c9-4546-a7d9-f25b42c72b50"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0093ae6c-d848-43bf-bc62-01c5e684f4a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ff89448-298d-4325-9c97-7cc25d0f0e8d", "AQAAAAEAACcQAAAAEOOxYnuDR5IW62hC+rtPUlKNTqd17xrib/0nnYSKRvhPDr/gzmmBKM6idI0PpTDFTg==", "a384d933-4a04-434b-855f-0be0a98bd357" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc60d5f7-3884-42c6-9fb5-e1db55094536",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "427386a4-f835-4785-8c36-58ef3acc39e6", "AQAAAAEAACcQAAAAEDj7H/ZnD3we4I8LVJH1UkRNPOiNg2WXi0fSO6yjcGdZdcmfVtMHnwFqfZGnt7XfsA==", "864742a0-6945-4a3f-bf67-fb342df787d5" });
        }
    }
}
