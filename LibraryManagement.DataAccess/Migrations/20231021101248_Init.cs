using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Personal",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Author = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ISBN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ReceivingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsBorrowed = table.Column<bool>(type: "bit", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Personal_PersonalId",
                        column: x => x.PersonalId,
                        principalSchema: "dbo",
                        principalTable: "Personal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Personal",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "IdentityNumber", "IsActive", "LastName", "PhoneNumber", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 10, 21, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(3919), "Aykut", "12345678901", true, "Öztürk", "12345678901", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "admin", new DateTime(2023, 10, 21, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(3937), "Kamil", "15789631485", true, "Ahmet", "15789631485", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Book",
                columns: new[] { "Id", "Author", "Name", "CreatedBy", "CreatedOn", "ISBN", "IsActive", "IsBorrowed", "PersonalId", "ReceivingDate", "ReturnDate", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { 1, "Victor Hugo", "Sefiller", null, new DateTime(2023, 10, 21, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(6630), "13345678912", true, false, 1, new DateTime(2023, 10, 11, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(6636), new DateTime(2023, 10, 22, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(6641), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Jose Mauro De Vasconcelos", "Şeker Portakalı", null, new DateTime(2023, 10, 21, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(6643), "13345678912", true, false, 2, new DateTime(2023, 10, 11, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(6643), new DateTime(2023, 10, 22, 13, 12, 48, 761, DateTimeKind.Local).AddTicks(6644), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_PersonalId",
                schema: "dbo",
                table: "Book",
                column: "PersonalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Personal",
                schema: "dbo");
        }
    }
}
