using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("35dab522-7a94-4b9a-aef6-c55b3420d4eb"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("79ddedbf-676d-47aa-966c-cdb03c1120c6"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("15002386-cca1-4bda-b772-c8f70cfb20e1"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("7be0359f-7035-4019-ae80-db2283685cdd"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("35dab522-7a94-4b9a-aef6-c55b3420d4eb"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 13, 14, 45, 35, 953, DateTimeKind.Local).AddTicks(9064) },
                    { new Guid("79ddedbf-676d-47aa-966c-cdb03c1120c6"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 13, 14, 45, 35, 957, DateTimeKind.Local).AddTicks(2988) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("15002386-cca1-4bda-b772-c8f70cfb20e1"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 13, 14, 45, 35, 957, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[] { new Guid("7be0359f-7035-4019-ae80-db2283685cdd"), "10 éve tanítok irodalmat és történelmet", null, "Bekes", "Ili", 250000, new DateTime(2020, 2, 13, 14, 45, 35, 957, DateTimeKind.Local).AddTicks(5197), "Heti 38 óra plusz helyettesítések" });
        }
    }
}
