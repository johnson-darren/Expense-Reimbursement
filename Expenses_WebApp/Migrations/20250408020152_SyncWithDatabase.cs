using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Expenses_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SyncWithDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "public",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Department_Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Department_ID);
                });

            migrationBuilder.CreateTable(
                name: "Receipt_Files",
                schema: "public",
                columns: table => new
                {
                    Receipt_File_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    File_Name = table.Column<string>(type: "text", nullable: false),
                    File_Data = table.Column<byte[]>(type: "bytea", nullable: false),
                    Uploaded_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt_Files", x => x.Receipt_File_ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "public",
                columns: table => new
                {
                    Role_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Role_Name = table.Column<string>(type: "text", nullable: false),
                    Role_Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Role_ID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                schema: "public",
                columns: table => new
                {
                    Status_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status_Name = table.Column<string>(type: "text", nullable: false),
                    Status_Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Status_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "public",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    First_Name = table.Column<string>(type: "text", nullable: false),
                    Last_Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Department_ID = table.Column<int>(type: "integer", nullable: false),
                    Department_ID1 = table.Column<int>(type: "integer", nullable: false),
                    Role_ID = table.Column<int>(type: "integer", nullable: false),
                    Role_ID1 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                    table.ForeignKey(
                        name: "FK_Users_Departments_Department_ID1",
                        column: x => x.Department_ID1,
                        principalSchema: "public",
                        principalTable: "Departments",
                        principalColumn: "Department_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Roles_Role_ID1",
                        column: x => x.Role_ID1,
                        principalSchema: "public",
                        principalTable: "Roles",
                        principalColumn: "Role_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                schema: "public",
                columns: table => new
                {
                    Receipt_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    User_ID = table.Column<int>(type: "integer", nullable: false),
                    User_ID1 = table.Column<int>(type: "integer", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    Date_Purchased = table.Column<DateOnly>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Status_ID = table.Column<int>(type: "integer", nullable: false),
                    Status_ID1 = table.Column<int>(type: "integer", nullable: false),
                    Receipt_File_ID = table.Column<int>(type: "integer", nullable: false),
                    Receipt_File_ID1 = table.Column<int>(type: "integer", nullable: false),
                    Submitted_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Checked_By = table.Column<int>(type: "integer", nullable: false),
                    Checked_At = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Receipt_ID);
                    table.ForeignKey(
                        name: "FK_Receipts_Receipt_Files_Receipt_File_ID1",
                        column: x => x.Receipt_File_ID1,
                        principalSchema: "public",
                        principalTable: "Receipt_Files",
                        principalColumn: "Receipt_File_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipts_Statuses_Status_ID1",
                        column: x => x.Status_ID1,
                        principalSchema: "public",
                        principalTable: "Statuses",
                        principalColumn: "Status_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receipts_Users_User_ID1",
                        column: x => x.User_ID1,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_Receipt_File_ID1",
                schema: "public",
                table: "Receipts",
                column: "Receipt_File_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_Status_ID1",
                schema: "public",
                table: "Receipts",
                column: "Status_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_User_ID1",
                schema: "public",
                table: "Receipts",
                column: "User_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Department_ID1",
                schema: "public",
                table: "Users",
                column: "Department_ID1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Role_ID1",
                schema: "public",
                table: "Users",
                column: "Role_ID1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Receipt_Files",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Statuses",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "public");
        }
    }
}
