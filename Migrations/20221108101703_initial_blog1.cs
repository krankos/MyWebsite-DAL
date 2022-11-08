using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebsiteDAL.Migrations
{
    /// <inheritdoc />
    public partial class initialblog1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Url" },
                values: new object[] { 1, "http://blogs.packtpub.com/dotnet" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "BlogId",
                keyValue: 1);
        }
    }
}
