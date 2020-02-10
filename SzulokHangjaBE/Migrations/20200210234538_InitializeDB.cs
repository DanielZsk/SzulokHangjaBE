using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class InitializeDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentPost",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ReviewTopic = table.Column<string>(nullable: true),
                    ReviewType = table.Column<bool>(nullable: false),
                    AgeOfChild = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentPost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherPost",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ReviewTopic = table.Column<string>(nullable: true),
                    ReviewType = table.Column<bool>(nullable: false),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPost", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "AgeOfChild", "Location", "ReviewTopic", "ReviewType", "Text", "Title" },
                values: new object[] { new Guid("a24f85ba-2dac-41ba-b1d0-6c31dee5f642"), 8, "ParentPost1", "Eszkoztar", false, "nezzetek ma milyen fikas a pad", "Szarok a padok a suliban" });

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "AgeOfChild", "Location", "ReviewTopic", "ReviewType", "Text", "Title" },
                values: new object[] { new Guid("9e6dfb96-8530-49fd-99b9-0e5ca9df6942"), 13, "ParentPost2", "NAT", true, "vegre olvassak mar a 50shds of greyt altalanosban", "Szuper jo az uj irodalom tanterv" });

            migrationBuilder.InsertData(
                table: "TeacherPost",
                columns: new[] { "Id", "Location", "ReviewTopic", "ReviewType", "Salary", "Text", "Title" },
                values: new object[] { new Guid("c0f51189-6ca7-45ce-ac85-ae8fd4cddd46"), "TeacherPost", "NAT", true, 1333333, "vegre olvassak mar a 50shds of greyt altalanosban", "Szuper jo az uj irodalom tanterv" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentPost");

            migrationBuilder.DropTable(
                name: "TeacherPost");
        }
    }
}
