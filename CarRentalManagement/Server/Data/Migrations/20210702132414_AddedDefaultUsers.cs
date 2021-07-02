using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696",
                column: "ConcurrencyStamp",
                value: "edd0ef26-7407-416a-967b-1d93a434d098");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c",
                column: "ConcurrencyStamp",
                value: "8b0a5201-54d3-4d8f-8efa-66d7dd04a9db");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07308287-b64a-458f-baaa-82c870e7ba69", 0, "51544e59-b275-4ac0-8d42-a128a8e0344c", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKS+VrQd5hol3Xw5Tgcp6oQVGWS3jbUiAgROeBkuaxUJLLpJVttF8VgaO7wyYyF82w==", null, false, "3db57bf5-0594-4eca-be86-8bbd2b586c22", false, "admin@localhost.com" },
                    { "8e795a5c-0ab5-4d3a-bba0-68b8e46ce73f", 0, "e2dde419-1584-4c61-92ac-a31ee3633c09", "user@localhost.com", false, "System", "User", false, null, "USERN@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFlS/Z2BXb19JOUuFTuRg8zmD9CuQplIuGweGsFPkGxLeU7zR++xGPXkRjKypGy4Vg==", null, false, "194ef387-6b54-47d0-91e4-0e6b62273f9b", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 151, DateTimeKind.Local).AddTicks(4259), new DateTime(2021, 7, 2, 15, 24, 14, 152, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 152, DateTimeKind.Local).AddTicks(7963), new DateTime(2021, 7, 2, 15, 24, 14, 152, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(49), new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(662), new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4161), new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4611), new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4678), new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4681), new DateTime(2021, 7, 2, 15, 24, 14, 154, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696", "07308287-b64a-458f-baaa-82c870e7ba69" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c", "8e795a5c-0ab5-4d3a-bba0-68b8e46ce73f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696", "07308287-b64a-458f-baaa-82c870e7ba69" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c", "8e795a5c-0ab5-4d3a-bba0-68b8e46ce73f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07308287-b64a-458f-baaa-82c870e7ba69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e795a5c-0ab5-4d3a-bba0-68b8e46ce73f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2ee65e55 - da0c - 405c - bbd6 - de6805ba6696",
                column: "ConcurrencyStamp",
                value: "3274016f-53da-4f5d-b648-c79bfe55fa1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92045038 - 7b66 - 4dfd - 9ba9 - 66dc23cd805c",
                column: "ConcurrencyStamp",
                value: "3ce1eea4-60cf-4967-be1a-c9ed9a3818c2");

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
    }
}
