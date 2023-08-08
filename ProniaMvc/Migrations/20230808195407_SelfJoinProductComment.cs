using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaMvc.Migrations
{
    public partial class SelfJoinProductComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "ProductComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_ParentId",
                table: "ProductComments",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductComments_ProductComments_ParentId",
                table: "ProductComments",
                column: "ParentId",
                principalTable: "ProductComments",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductComments_ProductComments_ParentId",
                table: "ProductComments");

            migrationBuilder.DropIndex(
                name: "IX_ProductComments_ParentId",
                table: "ProductComments");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "ProductComments");
        }
    }
}
