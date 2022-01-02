using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Paradox.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 360, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    SeoTitel = table.Column<string>(type: "TEXT", nullable: true),
                    Keyword = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 360, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClimes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 360, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    Password = table.Column<byte[]>(type: "NVARCHAR(255)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 360, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    SeoTitel = table.Column<string>(type: "TEXT", nullable: true),
                    Keyword = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    Thumbnail = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ViewsCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentCount = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    OperationClimeId = table.Column<int>(type: "INTEGER", nullable: false),
                    OperationClimeId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserOperationClimes_OperationClimes_OperationClimeId",
                        column: x => x.OperationClimeId,
                        principalTable: "OperationClimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClimes_OperationClimes_OperationClimeId1",
                        column: x => x.OperationClimeId1,
                        principalTable: "OperationClimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserOperationClimes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "Keyword", "ModifiedDate", "SeoTitel", "Title" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7241), "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.", true, false, "Groceries Groceries", new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7251), "Groceries", "Groceries" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "Keyword", "ModifiedDate", "SeoTitel", "Title" },
                values: new object[] { 2, new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7779), "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.", true, false, "HEALTHY EATING", new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7780), "HEALTHY EATING", "HEALTHY EATING" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "Keyword", "ModifiedDate", "SeoTitel", "Title" },
                values: new object[] { 3, new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7785), "Our supermarket shopping tips and product round-ups will help you make better food choices, save money, lose weight and ensure you and your family are getting complete nutrition from your groceries.", true, false, "RECIPES", new DateTime(2022, 1, 2, 15, 21, 32, 700, DateTimeKind.Local).AddTicks(7786), "RECIPES", "RECIPES" });

            migrationBuilder.InsertData(
                table: "OperationClimes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4041), true, false, new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4046), "Admin" });

            migrationBuilder.InsertData(
                table: "OperationClimes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Name" },
                values: new object[] { 2, new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4051), true, false, new DateTime(2022, 1, 2, 15, 21, 32, 704, DateTimeKind.Local).AddTicks(4052), "User" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FullName", "IsActive", "IsDeleted", "ModifiedDate", "Password" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1364), "cemhortoglu@gmail.com", "Cem Hortoglu", true, false, new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1370), new byte[] { 50, 49, 50, 51, 50, 102, 50, 57, 55, 97, 53, 55, 97, 53, 97, 55, 52, 51, 56, 57, 52, 97, 48, 101, 52, 97, 56, 48, 49, 102, 99, 51 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FullName", "IsActive", "IsDeleted", "ModifiedDate", "Password" },
                values: new object[] { 2, new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1381), "Admin@Admin.com", "Admin", true, false, new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1382), new byte[] { 50, 49, 50, 51, 50, 102, 50, 57, 55, 97, 53, 55, 97, 53, 97, 55, 52, 51, 56, 57, 52, 97, 48, 101, 52, 97, 56, 48, 49, 102, 99, 51 } });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "Email", "FullName", "IsActive", "IsDeleted", "ModifiedDate", "Password" },
                values: new object[] { 3, new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1519), "user@user.com", "User", true, false, new DateTime(2022, 1, 2, 15, 21, 32, 703, DateTimeKind.Local).AddTicks(1520), new byte[] { 50, 49, 50, 51, 50, 102, 50, 57, 55, 97, 53, 55, 97, 53, 97, 55, 52, 51, 56, 57, 52, 97, 48, 101, 52, 97, 56, 48, 49, 102, 99, 51 } });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedDate", "Date", "Description", "IsActive", "IsDeleted", "Keyword", "ModifiedDate", "SeoTitel", "Thumbnail", "Title", "ViewsCount" },
                values: new object[] { 1, 1, 0, "An MD5 hash is created by taking a string of an any length and encoding it into a 128-bit fingerprint. Encoding the same string using the MD5 algorithm will always result in the same 128-bit hash output. MD5 hashes are commonly used with smaller strings when storing passwords, credit card numbers or other sensitive data in databases such as the popular MySQL. This tool provides a quick and easy way to encode an MD5 hash from a simple string of up to 256 characters in length. MD5 hashes are also used to ensure the data integrity of files. Because the MD5 hash algorithm always produces the same output for the same given input, users can compare a hash of the source file with a newly created hash of the destination file to check that it is intact and unmodified. An MD5 hash is NOT encryption. It is simply a fingerprint of the given input. However, it is a one-way transaction and as such it is almost impossible to reverse engineer an MD5 hash to retrieve the original string.", new DateTime(2022, 1, 2, 15, 21, 32, 698, DateTimeKind.Local).AddTicks(4435), new DateTime(2022, 1, 2, 15, 21, 32, 698, DateTimeKind.Local).AddTicks(6101), "32-Character Hardwired LCD Keypad with built-in transceiver", true, false, "InitialCreate", new DateTime(2022, 1, 2, 15, 21, 32, 698, DateTimeKind.Local).AddTicks(4720), "InitialCreate", "Default.jpg", "32-Character Hardwired LCD Keypad with built-in transceiver", 0 });

            migrationBuilder.InsertData(
                table: "UserOperationClimes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "OperationClimeId", "OperationClimeId1", "UserId" },
                values: new object[] { 1, new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5155), true, false, new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5160), 1, null, 1 });

            migrationBuilder.InsertData(
                table: "UserOperationClimes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "OperationClimeId", "OperationClimeId1", "UserId" },
                values: new object[] { 2, new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5166), true, false, new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5167), 1, null, 2 });

            migrationBuilder.InsertData(
                table: "UserOperationClimes",
                columns: new[] { "Id", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "OperationClimeId", "OperationClimeId1", "UserId" },
                values: new object[] { 3, new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5171), true, false, new DateTime(2022, 1, 2, 15, 21, 32, 712, DateTimeKind.Local).AddTicks(5172), 2, null, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClimes_OperationClimeId",
                table: "UserOperationClimes",
                column: "OperationClimeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClimes_OperationClimeId1",
                table: "UserOperationClimes",
                column: "OperationClimeId1",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClimes_UserId",
                table: "UserOperationClimes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UserOperationClimes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "OperationClimes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
