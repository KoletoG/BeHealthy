using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeHealthy.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Height",
                table: "WeightDatas",
                newName: "LBM");

            migrationBuilder.RenameColumn(
                name: "BodyFatPercentage",
                table: "WeightDatas",
                newName: "BFP");

            migrationBuilder.AddColumn<double>(
                name: "Calories",
                table: "WeightDatas",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "AspNetUsers",
                type: "float",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WeightHistoryDatas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightHistoryDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightHistoryDatas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeightHistoryDatas_UserId",
                table: "WeightHistoryDatas",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeightHistoryDatas");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "WeightDatas");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LBM",
                table: "WeightDatas",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "BFP",
                table: "WeightDatas",
                newName: "BodyFatPercentage");
        }
    }
}
