using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeHealthy.Data.Migrations
{
    public partial class ReposModelsFinalFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeightHistoryDataModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WeightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    WeightDataModelId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                name: "IX_WeightHistoryDataModel_WeightDataModelId",
                table: "WeightHistoryDataModel",
                column: "WeightDataModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeightHistoryDataModel");
        }
    }
}
