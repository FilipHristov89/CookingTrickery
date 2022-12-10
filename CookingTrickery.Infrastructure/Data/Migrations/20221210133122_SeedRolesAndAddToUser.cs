using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CookingTrickery.Infrastructure.Data.Migrations
{
    public partial class SeedRolesAndAddToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d2b7fd6f-b310-47af-8669-0517e64ac4b6", "974f5276-0850-4225-a6dd-eaca17b9fbe7", "Administrator", "ADMINISTRATOR" });


            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d2b7fd6f-b310-47af-8669-0517e64ac4b6", "0093ae6c-d848-43bf-bc62-01c5e684f4a4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d2b7fd6f-b310-47af-8669-0517e64ac4b6", "0093ae6c-d848-43bf-bc62-01c5e684f4a4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2b7fd6f-b310-47af-8669-0517e64ac4b6");

        }
    }
}
