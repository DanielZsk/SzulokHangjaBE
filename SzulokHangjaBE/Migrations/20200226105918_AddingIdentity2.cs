using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class AddingIdentity2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("ab2305eb-e328-407b-964a-7f68c4d3e50e"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("b72720db-14b3-4ac8-8c6c-667da09838dc"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("748bf88d-159d-4d2c-b67c-a82d58dbcf97"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("d9ec9ebf-3520-4bfc-a7ce-218fc174b9cc"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("eeb3284c-516c-4387-9e0c-5b9f56771799"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("ab2305eb-e328-407b-964a-7f68c4d3e50e"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 26, 11, 9, 25, 192, DateTimeKind.Local).AddTicks(4333) },
                    { new Guid("b72720db-14b3-4ac8-8c6c-667da09838dc"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 26, 11, 9, 25, 197, DateTimeKind.Local).AddTicks(2220) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("748bf88d-159d-4d2c-b67c-a82d58dbcf97"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 26, 11, 9, 25, 197, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[,]
                {
                    { new Guid("eeb3284c-516c-4387-9e0c-5b9f56771799"), "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", null, "Bekes", "Ili", 250000, new DateTime(2020, 2, 26, 11, 9, 25, 197, DateTimeKind.Local).AddTicks(4493), "Heti 38 óra plusz helyettesítések" },
                    { new Guid("d9ec9ebf-3520-4bfc-a7ce-218fc174b9cc"), "10 éve tanítok irodalmat és történelmet", null, "Pjost", "Zsuzs", 2232323, new DateTime(2020, 2, 26, 11, 9, 25, 197, DateTimeKind.Local).AddTicks(6172), "Heti 38 óra plusz helyettesítések" }
                });
        }
    }
}
