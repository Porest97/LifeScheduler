using Microsoft.EntityFrameworkCore.Migrations;

namespace LifeScheduler.Migrations
{
    public partial class Changed_In_ApplicationUserPerson_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserPerson",
                table: "ApplicationUserPerson");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserPerson_PersonId",
                table: "ApplicationUserPerson");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApplicationUserPerson");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserPerson",
                table: "ApplicationUserPerson",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUserPerson",
                table: "ApplicationUserPerson");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ApplicationUserPerson",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUserPerson",
                table: "ApplicationUserPerson",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserPerson_PersonId",
                table: "ApplicationUserPerson",
                column: "PersonId");
        }
    }
}
