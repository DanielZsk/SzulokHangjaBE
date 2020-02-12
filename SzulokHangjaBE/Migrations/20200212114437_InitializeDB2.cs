using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class InitializeDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherPost");

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("9e6dfb96-8530-49fd-99b9-0e5ca9df6942"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("a24f85ba-2dac-41ba-b1d0-6c31dee5f642"));

            migrationBuilder.DropColumn(
                name: "AgeOfChild",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "ReviewTopic",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "ReviewType",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ParentPost");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "ParentPost",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentType",
                table: "ParentPost",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "ParentPost",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "ParentPost",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "PositiveMessage",
                table: "ParentPost",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmissionDate",
                table: "ParentPost",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TeacherPostRecommendation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    SubmissionDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Recommendation = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPostRecommendation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeacherPostSalary",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    SubmissionDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: false),
                    Workload = table.Column<string>(nullable: false),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherPostSalary", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "CommentType", "Image", "Location", "Message", "PositiveMessage", "SubmissionDate" },
                values: new object[] { new Guid("8afea9c2-83ad-4c74-99a3-b0466a38b6f2"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 12, 12, 44, 36, 993, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "CommentType", "Image", "Location", "Message", "PositiveMessage", "SubmissionDate" },
                values: new object[] { new Guid("c4827f96-d7cf-43d2-928d-63049143fb4b"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 12, 12, 44, 36, 996, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("b8c5f1fd-fb7f-4379-b893-7113404378e8"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 12, 12, 44, 36, 996, DateTimeKind.Local).AddTicks(9677) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherPostRecommendation");

            migrationBuilder.DropTable(
                name: "TeacherPostSalary");

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("8afea9c2-83ad-4c74-99a3-b0466a38b6f2"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("c4827f96-d7cf-43d2-928d-63049143fb4b"));

            migrationBuilder.DropColumn(
                name: "CommentType",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "PositiveMessage",
                table: "ParentPost");

            migrationBuilder.DropColumn(
                name: "SubmissionDate",
                table: "ParentPost");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "ParentPost",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "AgeOfChild",
                table: "ParentPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReviewTopic",
                table: "ParentPost",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ReviewType",
                table: "ParentPost",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "ParentPost",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ParentPost",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeacherPost",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewTopic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewType = table.Column<bool>(type: "bit", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
