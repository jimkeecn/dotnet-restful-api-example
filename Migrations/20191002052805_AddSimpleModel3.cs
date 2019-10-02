using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnetRestfulAPI.Migrations
{
    public partial class AddSimpleModel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_simpleModel",
                table: "simpleModel");

            migrationBuilder.RenameTable(
                name: "simpleModel",
                newName: "SimpleModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SimpleModel",
                table: "SimpleModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SimpleModel",
                table: "SimpleModel");

            migrationBuilder.RenameTable(
                name: "SimpleModel",
                newName: "simpleModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_simpleModel",
                table: "simpleModel",
                column: "Id");
        }
    }
}
