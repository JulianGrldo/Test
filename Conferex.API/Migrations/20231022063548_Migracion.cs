using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Conferex.API.Migrations
{
    /// <inheritdoc />
    public partial class Migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assistants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentAsis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameAsis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAsis = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    OrganizationAsis = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberConf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateConf = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameConf = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DateConf = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AddresConf = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SizeConf = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PriceConf = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOrga = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EmailOrga = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleConferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleConferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleIni = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ScheduleFin = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescriptionConf = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sponsors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamePatro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ScalePatro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleConfer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SpeakerConfer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DescriptionConf = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ScheduleIni = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ScheduleFin = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assistants_DocumentAsis",
                table: "Assistants",
                column: "DocumentAsis",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_NumberConf",
                table: "Attendances",
                column: "NumberConf",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_NameOrga",
                table: "Organizers",
                column: "NameOrga",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ScheduleIni",
                table: "Schedules",
                column: "ScheduleIni",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sponsors_NamePatro",
                table: "Sponsors",
                column: "NamePatro",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_SpeakerConfer",
                table: "Topics",
                column: "SpeakerConfer",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assistants");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "Conferences");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "ScheduleConferences");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Sponsors");

            migrationBuilder.DropTable(
                name: "Topics");
        }
    }
}
