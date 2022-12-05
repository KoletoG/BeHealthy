using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeHealthy.Data.Migrations
{
    public partial class Fix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeightDatas_AspNetUsers_UserId",
                table: "WeightDatas");

            migrationBuilder.DropIndex(
                name: "IX_WeightDatas_UserId",
                table: "WeightDatas");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "WeightDatas");

            migrationBuilder.AddColumn<string>(
                name: "WeightDataId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WeightDataId",
                table: "AspNetUsers",
                column: "WeightDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WeightDatas_WeightDataId",
                table: "AspNetUsers",
                column: "WeightDataId",
                principalTable: "WeightDatas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WeightDatas_WeightDataId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WeightDataId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WeightDataId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "WeightDatas",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_WeightDatas_UserId",
                table: "WeightDatas",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeightDatas_AspNetUsers_UserId",
                table: "WeightDatas",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
