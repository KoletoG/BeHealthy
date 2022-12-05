using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeHealthy.Data.Migrations
{
    public partial class Fixxx : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WeightDatas_WeightDataId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WeightHistoryDataModel");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "WeightHistoryDataModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    WeightDataModelId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WeightDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightHistoryDataModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightHistoryDataModel_WeightDatas_WeightDataModelId",
                        column: x => x.WeightDataModelId,
                        principalTable: "WeightDatas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WeightDataId",
                table: "AspNetUsers",
                column: "WeightDataId");

            migrationBuilder.CreateIndex(
                name: "IX_WeightHistoryDataModel_WeightDataModelId",
                table: "WeightHistoryDataModel",
                column: "WeightDataModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WeightDatas_WeightDataId",
                table: "AspNetUsers",
                column: "WeightDataId",
                principalTable: "WeightDatas",
                principalColumn: "Id");
        }
    }
}
