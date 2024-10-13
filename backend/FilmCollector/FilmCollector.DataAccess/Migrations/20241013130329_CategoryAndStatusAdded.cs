using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmCollector.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CategoryAndStatusAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM \"Films\""); 
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Films",
                type: "uuid",
                nullable: false,
                defaultValue: Guid.Empty);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Films",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Films",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Films",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Uri",
                table: "Films",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_CategoryId",
                table: "Films",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Categories_CategoryId",
                table: "Films");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Films_CategoryId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Uri",
                table: "Films");
        }
    }
}
