using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CCY.MyAirport.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vol",
                columns: table => new
                {
                    VolId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pax = table.Column<int>(nullable: false),
                    Dhc = table.Column<DateTime>(nullable: false),
                    Cie = table.Column<string>(nullable: true),
                    Des = table.Column<string>(nullable: true),
                    Imm = table.Column<string>(nullable: true),
                    Lig = table.Column<string>(nullable: true),
                    Pkg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vol", x => x.VolId);
                });

            migrationBuilder.CreateTable(
                name: "Bagage",
                columns: table => new
                {
                    BagageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolId = table.Column<int>(nullable: false),
                    Prioritaire = table.Column<bool>(nullable: false),
                    DateCreation = table.Column<DateTime>(nullable: false),
                    CodeIata = table.Column<string>(nullable: true),
                    Classe = table.Column<string>(nullable: true),
                    Sta = table.Column<string>(nullable: true),
                    Ssur = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Escale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagage", x => x.BagageId);
                    table.ForeignKey(
                        name: "FK_Bagage_Vol_VolId",
                        column: x => x.VolId,
                        principalTable: "Vol",
                        principalColumn: "VolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bagage_VolId",
                table: "Bagage",
                column: "VolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagage");

            migrationBuilder.DropTable(
                name: "Vol");
        }
    }
}
