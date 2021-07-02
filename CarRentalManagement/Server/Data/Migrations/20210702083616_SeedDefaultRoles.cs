using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c", "3ce1eea4-60cf-4967-be1a-c9ed9a3818c2", "User", "USER" },
                    { "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696", "3274016f-53da-4f5d-b648-c79bfe55fa1f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 515, DateTimeKind.Local).AddTicks(7209), new DateTime(2021, 7, 2, 10, 36, 15, 516, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 517, DateTimeKind.Local).AddTicks(450), new DateTime(2021, 7, 2, 10, 36, 15, 517, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(2657), new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(3134), new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(6691), new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(7159), new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(7165), new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(7167), new DateTime(2021, 7, 2, 10, 36, 15, 518, DateTimeKind.Local).AddTicks(7168) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 673, DateTimeKind.Local).AddTicks(1835), new DateTime(2021, 7, 2, 10, 21, 23, 674, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 674, DateTimeKind.Local).AddTicks(7138), new DateTime(2021, 7, 2, 10, 21, 23, 674, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(320), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(799), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(803) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4503), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4984), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4989), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4991), new DateTime(2021, 7, 2, 10, 21, 23, 676, DateTimeKind.Local).AddTicks(4992) });
        }
    }
}
