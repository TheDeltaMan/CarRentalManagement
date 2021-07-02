using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 2, 10, 21, 23, 673, DateTimeKind.Local).AddTicks(1835), new DateTime(2021, 7, 2, 10, 21, 23, 674, DateTimeKind.Local).AddTicks(5779), "Black", "System" },
                    { 2, "System", new DateTime(2021, 7, 2, 10, 21, 23, 674, DateTimeKind.Local).AddTicks(7138), new DateTime(2021, 7, 2, 10, 21, 23, 674, DateTimeKind.Local).AddTicks(7142), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(332), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(799), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(803), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4503), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4508), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4984), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4987), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4989), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4990), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4991), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4992), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
