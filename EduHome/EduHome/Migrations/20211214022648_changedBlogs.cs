using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHome.Migrations
{
    public partial class changedBlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagToBlogs_BlogTags_ATagId",
                table: "TagToBlogs");

            migrationBuilder.RenameColumn(
                name: "ATagId",
                table: "TagToBlogs",
                newName: "TagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagToBlogs_ATagId",
                table: "TagToBlogs",
                newName: "IX_TagToBlogs_TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBlogs_BlogTags_TagId",
                table: "TagToBlogs",
                column: "TagId",
                principalTable: "BlogTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagToBlogs_BlogTags_TagId",
                table: "TagToBlogs");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "TagToBlogs",
                newName: "ATagId");

            migrationBuilder.RenameIndex(
                name: "IX_TagToBlogs_TagId",
                table: "TagToBlogs",
                newName: "IX_TagToBlogs_ATagId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagToBlogs_BlogTags_ATagId",
                table: "TagToBlogs",
                column: "ATagId",
                principalTable: "BlogTags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
