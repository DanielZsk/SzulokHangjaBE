using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class migrancs3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("a4b160e5-bc68-4a04-a5d5-fb2496584373"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("eaab5f2a-2f85-4be4-9ecb-f7db52a57fcb"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("078c03b0-5beb-4315-96b1-9af2320afe19"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("1607bbde-6a2e-40f7-b020-8b6f88f3d9a8"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("d5436537-918a-4047-8c58-c6c55c666f36"));

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "CommentType", "Image", "Location", "Message", "PositiveMessage", "SubmissionDate" },
                values: new object[,]
                {
                    { new Guid("b7caa41f-5b3e-40cc-926c-d93876e013ab"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 15, 13, 42, 44, 334, DateTimeKind.Local).AddTicks(9943) },
                    { new Guid("7b532493-cd53-4ef3-b74f-fc9fe0827780"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 15, 13, 42, 44, 339, DateTimeKind.Local).AddTicks(9108) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("236d7c92-50df-4cb9-873a-2202addaed1b"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 15, 13, 42, 44, 340, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[,]
                {
                    { new Guid("5c8a01af-2e06-42e1-be7d-e9bf1a9f43f2"), "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", null, "Bekes", "Ili", 250000, new DateTime(2020, 2, 15, 13, 42, 44, 340, DateTimeKind.Local).AddTicks(2294), "Heti 38 óra plusz helyettesítések" },
                    { new Guid("d50778f5-2f5f-4412-82ea-ec533f218a11"), "10 éve tanítok irodalmat és történelmet", null, "Pjost", "Zsuzs", 2232323, new DateTime(2020, 2, 15, 13, 42, 44, 340, DateTimeKind.Local).AddTicks(5163), "Heti 38 óra plusz helyettesítések" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("7b532493-cd53-4ef3-b74f-fc9fe0827780"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("b7caa41f-5b3e-40cc-926c-d93876e013ab"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("236d7c92-50df-4cb9-873a-2202addaed1b"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("5c8a01af-2e06-42e1-be7d-e9bf1a9f43f2"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("d50778f5-2f5f-4412-82ea-ec533f218a11"));

            migrationBuilder.InsertData(
                table: "ParentPost",
                columns: new[] { "Id", "CommentType", "Image", "Location", "Message", "PositiveMessage", "SubmissionDate" },
                values: new object[,]
                {
                    { new Guid("a4b160e5-bc68-4a04-a5d5-fb2496584373"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 13, 23, 44, 17, 15, DateTimeKind.Local).AddTicks(5120) },
                    { new Guid("eaab5f2a-2f85-4be4-9ecb-f7db52a57fcb"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 13, 23, 44, 17, 18, DateTimeKind.Local).AddTicks(5159) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("078c03b0-5beb-4315-96b1-9af2320afe19"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 13, 23, 44, 17, 18, DateTimeKind.Local).AddTicks(5673) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[,]
                {
                    { new Guid("d5436537-918a-4047-8c58-c6c55c666f36"), "5 éve tanítok irodcdccdcdcdcdcdcdcdcdcdcdcdcddcds történelmet", null, "Bekes", "Ili", 250000, new DateTime(2020, 2, 13, 23, 44, 17, 18, DateTimeKind.Local).AddTicks(6635), "Heti 38 óra plusz helyettesítések" },
                    { new Guid("1607bbde-6a2e-40f7-b020-8b6f88f3d9a8"), "10 éve tanítok irodalmat és történelmet", null, "Pjost", "Zsuzs", 2232323, new DateTime(2020, 2, 13, 23, 44, 17, 18, DateTimeKind.Local).AddTicks(7577), "Heti 38 óra plusz helyettesítések" }
                });
        }
    }
}
