using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SzulokHangjaBE.Migrations
{
    public partial class AddingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
    }
}
