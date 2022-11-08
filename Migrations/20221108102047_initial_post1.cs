using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebsiteDAL.Migrations
{
    /// <inheritdoc />
    public partial class initialpost1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "PublisedDateTime", "Title" },
                values: new object[] { 2, 1, "lorem ipsum", null, "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: 2);
        }
    }
}
