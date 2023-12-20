using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "links");

            migrationBuilder.CreateTable(
                name: "ButtonLink",
                schema: "links",
                columns: table => new
                {
                    ButtonLinkId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Body = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Url = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Icon = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 636, DateTimeKind.Unspecified).AddTicks(8383), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 636, DateTimeKind.Unspecified).AddTicks(8786), new TimeSpan(0, 0, 0, 0, 0))),
                    ButtonLinkType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ButtonLink", x => x.ButtonLinkId);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                schema: "links",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: false),
                    CreateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 637, DateTimeKind.Unspecified).AddTicks(973), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 637, DateTimeKind.Unspecified).AddTicks(1245), new TimeSpan(0, 0, 0, 0, 0))),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MemberType = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.CreateTable(
                name: "Bios",
                schema: "links",
                columns: table => new
                {
                    BioId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Image = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Url = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 635, DateTimeKind.Unspecified).AddTicks(6846), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 635, DateTimeKind.Unspecified).AddTicks(7561), new TimeSpan(0, 0, 0, 0, 0))),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bios", x => x.BioId);
                    table.ForeignKey(
                        name: "FK_Bios_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "links",
                        principalTable: "Members",
                        principalColumn: "MemberId");
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                schema: "links",
                columns: table => new
                {
                    ContentId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    ContentType = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Body = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Url = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Icon = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 636, DateTimeKind.Unspecified).AddTicks(9798), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 637, DateTimeKind.Unspecified).AddTicks(103), new TimeSpan(0, 0, 0, 0, 0))),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false),
                    BioId = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.ContentId);
                    table.ForeignKey(
                        name: "FK_Contents_Bios_BioId",
                        column: x => x.BioId,
                        principalSchema: "links",
                        principalTable: "Bios",
                        principalColumn: "BioId");
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                schema: "links",
                columns: table => new
                {
                    SocialMediaId = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: false),
                    UserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    Icon = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true),
                    CreateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 637, DateTimeKind.Unspecified).AddTicks(2309), new TimeSpan(0, 0, 0, 0, 0))),
                    UpdateAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false, defaultValue: new DateTimeOffset(new DateTime(2023, 12, 18, 18, 27, 44, 637, DateTimeKind.Unspecified).AddTicks(2570), new TimeSpan(0, 0, 0, 0, 0))),
                    SocialMediaType = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false),
                    BioId = table.Column<string>(type: "varchar(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.SocialMediaId);
                    table.ForeignKey(
                        name: "FK_SocialMedias_Bios_BioId",
                        column: x => x.BioId,
                        principalSchema: "links",
                        principalTable: "Bios",
                        principalColumn: "BioId");
                });

            migrationBuilder.InsertData(
                schema: "links",
                table: "Members",
                columns: new[] { "MemberId", "Email", "FirstName", "IsDeleted", "LastName", "MemberType", "Status" },
                values: new object[] { "User_kc6alletqg", "Scott.l.griffin@gmail.com", "Scott", 0, "Griffin", 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Bios_MemberId",
                schema: "links",
                table: "Bios",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_BioId",
                schema: "links",
                table: "Contents",
                column: "BioId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_BioId",
                schema: "links",
                table: "SocialMedias",
                column: "BioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ButtonLink",
                schema: "links");

            migrationBuilder.DropTable(
                name: "Contents",
                schema: "links");

            migrationBuilder.DropTable(
                name: "SocialMedias",
                schema: "links");

            migrationBuilder.DropTable(
                name: "Bios",
                schema: "links");

            migrationBuilder.DropTable(
                name: "Members",
                schema: "links");
        }
    }
}
