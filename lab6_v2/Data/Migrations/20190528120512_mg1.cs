using Microsoft.EntityFrameworkCore.Migrations;

namespace lab6_v2.Data.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Topic_CategoryId",
                table: "Topic",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_TopicId",
                table: "Post",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Topic_TopicId",
                table: "Post",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Category_CategoryId",
                table: "Topic",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Topic_TopicId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Category_CategoryId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Topic_CategoryId",
                table: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Post_TopicId",
                table: "Post");
        }
    }
}
