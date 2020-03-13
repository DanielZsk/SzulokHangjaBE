using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class AddingIdentity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("2cdd961a-b346-4688-97f6-14d96b8c37aa"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("b05dfead-aa2a-439e-a58b-132d2f28e536"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("3072f8e0-10e8-4504-984e-609b6f74efcb"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("744835e0-1938-409a-815f-1ef56b52c790"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("ed5125f9-8b48-4d1f-a1f0-fad8890f3d8d"));

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "CommentType", "Image", "Location", "Message", "PositiveMessage", "SubmissionDate" },
                values: new object[,]
                {
                    { new Guid("28f7ee81-a773-4af2-afa5-3e7f1a7ac4c9"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("564c924a-f5d3-4f71-a827-bb52a7f7a3ae"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("34030e13-2dbe-4ded-8366-f5fac45b052d"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[,]
                {
                    { new Guid("01ac39b2-2d78-46c8-ae50-bf3a8b4774d7"), "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", null, "Bekes", "Ili", 250000, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heti 38 óra plusz helyettesítések" },
                    { new Guid("c8c8090e-750e-4688-bb2e-9f6caa8fc3c0"), "10 éve tanítok irodalmat és történelmet", null, "Pjost", "Zsuzs", 2232323, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heti 38 óra plusz helyettesítések" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("28f7ee81-a773-4af2-afa5-3e7f1a7ac4c9"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("564c924a-f5d3-4f71-a827-bb52a7f7a3ae"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("34030e13-2dbe-4ded-8366-f5fac45b052d"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("01ac39b2-2d78-46c8-ae50-bf3a8b4774d7"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("c8c8090e-750e-4688-bb2e-9f6caa8fc3c0"));

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "CommentType", "Image", "Location", "Message", "PositiveMessage", "SubmissionDate" },
                values: new object[,]
                {
                    { new Guid("2cdd961a-b346-4688-97f6-14d96b8c37aa"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 26, 11, 59, 17, 907, DateTimeKind.Local).AddTicks(6569) },
                    { new Guid("b05dfead-aa2a-439e-a58b-132d2f28e536"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 26, 11, 59, 17, 911, DateTimeKind.Local).AddTicks(3290) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("3072f8e0-10e8-4504-984e-609b6f74efcb"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 26, 11, 59, 17, 911, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[,]
                {
                    { new Guid("ed5125f9-8b48-4d1f-a1f0-fad8890f3d8d"), "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", null, "Bekes", "Ili", 250000, new DateTime(2020, 2, 26, 11, 59, 17, 911, DateTimeKind.Local).AddTicks(5495), "Heti 38 óra plusz helyettesítések" },
                    { new Guid("744835e0-1938-409a-815f-1ef56b52c790"), "10 éve tanítok irodalmat és történelmet", null, "Pjost", "Zsuzs", 2232323, new DateTime(2020, 2, 26, 11, 59, 17, 911, DateTimeKind.Local).AddTicks(7209), "Heti 38 óra plusz helyettesítések" }
                });
        }
    }
}
