using Microsoft.EntityFrameworkCore.Migrations;

namespace CCY.MyAirport.EF.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagage_Vol_VolId",
                table: "Bagage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vol",
                table: "Vol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bagage",
                table: "Bagage");

            migrationBuilder.RenameTable(
                name: "Vol",
                newName: "Vols");

            migrationBuilder.RenameTable(
                name: "Bagage",
                newName: "Bagages");

            migrationBuilder.RenameIndex(
                name: "IX_Bagage_VolId",
                table: "Bagages",
                newName: "IX_Bagages_VolId");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vols",
                table: "Vols",
                column: "VolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bagages",
                table: "Bagages",
                column: "BagageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages",
                column: "VolId",
                principalTable: "Vols",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagages_Vols_VolId",
                table: "Bagages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vols",
                table: "Vols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bagages",
                table: "Bagages");

            migrationBuilder.RenameTable(
                name: "Vols",
                newName: "Vol");

            migrationBuilder.RenameTable(
                name: "Bagages",
                newName: "Bagage");

            migrationBuilder.RenameIndex(
                name: "IX_Bagages_VolId",
                table: "Bagage",
                newName: "IX_Bagage_VolId");

            migrationBuilder.AlterColumn<int>(
                name: "VolId",
                table: "Bagage",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vol",
                table: "Vol",
                column: "VolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bagage",
                table: "Bagage",
                column: "BagageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagage_Vol_VolId",
                table: "Bagage",
                column: "VolId",
                principalTable: "Vol",
                principalColumn: "VolId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
