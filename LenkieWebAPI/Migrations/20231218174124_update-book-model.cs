using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LenkieWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatebookmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "ShortDescription", "imageUrl" },
                values: new object[] { null, "https://placehold.co/603x403" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "ShortDescription", "imageUrl" },
                values: new object[] { null, "https://placehold.co/603x403" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "ShortDescription", "imageUrl" },
                values: new object[] { null, "https://placehold.co/603x403" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "ShortDescription", "imageUrl" },
                values: new object[] { null, "https://placehold.co/603x403" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "ShortDescription", "imageUrl" },
                values: new object[] { null, "https://placehold.co/603x403" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Books");
        }
    }
}
