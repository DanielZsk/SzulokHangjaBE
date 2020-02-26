using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class migrancs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("8afea9c2-83ad-4c74-99a3-b0466a38b6f2"));

            migrationBuilder.DeleteData(
                table: "ParentPost",
                keyColumn: "Id",
                keyValue: new Guid("c4827f96-d7cf-43d2-928d-63049143fb4b"));

            migrationBuilder.DeleteData(
                table: "TeacherPostRecommendation",
                keyColumn: "Id",
                keyValue: new Guid("b8c5f1fd-fb7f-4379-b893-7113404378e8"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
