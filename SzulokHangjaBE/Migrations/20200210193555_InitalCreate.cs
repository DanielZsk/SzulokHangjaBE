using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperPost",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ReviewTopic = table.Column<string>(nullable: true),
                    ReviewType = table.Column<bool>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    AgeOfChild = table.Column<int>(nullable: true),
                    Salary = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperPost", x => x.Id);
                });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperPost");
        }
    }
}
