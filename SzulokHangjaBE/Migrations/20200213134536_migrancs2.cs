using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class migrancs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("75dee788-32a5-46fe-a743-35f9735c0272"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("b882cd95-fee7-4145-8a6f-a114909b3559"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("4cad1581-8923-4f07-825e-38cadac8ebe4"));

            migrationBuilder.DeleteData(
                table: "TeacherPostSalary",
                keyColumn: "Id",
                keyValue: new Guid("cf5db75f-6c25-4b43-9a15-18a662de5b6d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("75dee788-32a5-46fe-a743-35f9735c0272"), 1, null, "Budapest", "Ninncs helyettesítés betegség idején", false, new DateTime(2020, 2, 13, 8, 57, 40, 373, DateTimeKind.Local).AddTicks(2479) },
                    { new Guid("b882cd95-fee7-4145-8a6f-a114909b3559"), 0, null, "Vas", "Szuper jo az uj irodalom tanterv", true, new DateTime(2020, 2, 13, 8, 57, 40, 376, DateTimeKind.Local).AddTicks(5366) }
                });

            migrationBuilder.InsertData(
                table: "TeacherPostRecommendation",
                columns: new[] { "Id", "Location", "Name", "Recommendation", "SubmissionDate" },
                values: new object[] { new Guid("4cad1581-8923-4f07-825e-38cadac8ebe4"), "Zala", "Maris", "Több szabadságot a tanároknak", new DateTime(2020, 2, 13, 8, 57, 40, 376, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.InsertData(
                table: "TeacherPostSalary",
                columns: new[] { "Id", "Experience", "Image", "Location", "Name", "Salary", "SubmissionDate", "Workload" },
                values: new object[] { new Guid("cf5db75f-6c25-4b43-9a15-18a662de5b6d"), "10 éve tanítok irodalmat és történelmet", null, "Bekes", "Ili", 250000, new DateTime(2020, 2, 13, 8, 57, 40, 376, DateTimeKind.Local).AddTicks(7926), "Heti 38 óra plusz helyettesítések" });
        }
    }
}
