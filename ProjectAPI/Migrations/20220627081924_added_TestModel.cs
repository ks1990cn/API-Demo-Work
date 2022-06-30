using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectAPI.Migrations
{
    public partial class added_TestModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestModelTestID",
                table: "Quotes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "testModels",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_testModels", x => x.TestID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_TestModelTestID",
                table: "Quotes",
                column: "TestModelTestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_testModels_TestModelTestID",
                table: "Quotes",
                column: "TestModelTestID",
                principalTable: "testModels",
                principalColumn: "TestID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_testModels_TestModelTestID",
                table: "Quotes");

            migrationBuilder.DropTable(
                name: "testModels");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_TestModelTestID",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "TestModelTestID",
                table: "Quotes");
        }
    }
}
