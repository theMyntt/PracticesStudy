using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Patterns.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniqueModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TBL_CARROS",
                newName: "ID_CARRO");

            migrationBuilder.AlterColumn<string>(
                name: "TX_MODELO",
                table: "TBL_CARROS",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_CARROS_TX_MODELO",
                table: "TBL_CARROS",
                column: "TX_MODELO",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TBL_CARROS_TX_MODELO",
                table: "TBL_CARROS");

            migrationBuilder.RenameColumn(
                name: "ID_CARRO",
                table: "TBL_CARROS",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "TX_MODELO",
                table: "TBL_CARROS",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
