using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Migrations
{
    public partial class TeamTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    BgImg = table.Column<string>(nullable:true),
                    Icon1=table.Column<string>(nullable:true),
                    Icon2=table.Column<string>(nullable:true),
                    Icon3=table.Column<string>(nullable:true),
                    Icon4=table.Column<string>(nullable:true),
                    Name=table.Column<string>(nullable:true),
                    Position=table.Column<string>(nullable:true)
                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                }) ;

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name:"Members"
                );
        }
    }
}
