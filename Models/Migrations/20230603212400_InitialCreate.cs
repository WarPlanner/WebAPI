using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guilds",
                columns: table => new
                {
                    Id = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Language = table.Column<long>(type: "bigint", nullable: false),
                    PremiumLevel = table.Column<long>(type: "bigint", nullable: false),
                    MinThLevel = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guilds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChannelId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: true),
                    MessageId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.GuildId);
                    table.ForeignKey(
                        name: "FK_Calendars_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clans",
                columns: table => new
                {
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clans", x => new { x.GuildId, x.Tag });
                    table.ForeignKey(
                        name: "FK_Clans_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competitions",
                columns: table => new
                {
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    CategoryId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    ResultId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainClan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondClan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitions", x => new { x.GuildId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_Competitions_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiscordId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => new { x.GuildId, x.Tag });
                    table.ForeignKey(
                        name: "FK_Players_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStatistics",
                columns: table => new
                {
                    DiscordId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    ClanTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WarDateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AttackOrder = table.Column<long>(type: "bigint", nullable: false),
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    PlayerTag = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WarType = table.Column<long>(type: "bigint", nullable: false),
                    StatisticType = table.Column<long>(type: "bigint", nullable: false),
                    StatisticAction = table.Column<long>(type: "bigint", nullable: false),
                    Stars = table.Column<long>(type: "bigint", nullable: false),
                    Percentage = table.Column<long>(type: "bigint", nullable: false),
                    Duration = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatistics", x => new { x.DiscordId, x.ClanTag, x.WarDateStart, x.AttackOrder });
                    table.ForeignKey(
                        name: "FK_PlayerStatistics_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Type = table.Column<long>(type: "bigint", nullable: false),
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => new { x.RoleId, x.Type });
                    table.ForeignKey(
                        name: "FK_Roles_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    Action = table.Column<long>(type: "bigint", nullable: false),
                    Additional = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Interval = table.Column<long>(type: "bigint", nullable: false),
                    Optional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => new { x.GuildId, x.Action, x.Additional });
                    table.ForeignKey(
                        name: "FK_Times_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WarStatistics",
                columns: table => new
                {
                    DateStart = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ClanTag = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GuildId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: false),
                    WarType = table.Column<long>(type: "bigint", nullable: false),
                    CompetitionCategoryId = table.Column<decimal>(type: "decimal(30,0)", precision: 30, scale: 0, nullable: true),
                    OpponentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<long>(type: "bigint", nullable: false),
                    AttackStars = table.Column<long>(type: "bigint", nullable: false),
                    AttackPercent = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    AttackAvgDuration = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    DefenseStars = table.Column<long>(type: "bigint", nullable: false),
                    DefensePercent = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false),
                    DefenseAvgDuration = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarStatistics", x => new { x.DateStart, x.ClanTag });
                    table.ForeignKey(
                        name: "FK_WarStatistics_Guilds_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guilds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistics_GuildId",
                table: "PlayerStatistics",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_GuildId",
                table: "Roles",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_WarStatistics_GuildId",
                table: "WarStatistics",
                column: "GuildId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Clans");

            migrationBuilder.DropTable(
                name: "Competitions");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PlayerStatistics");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Times");

            migrationBuilder.DropTable(
                name: "WarStatistics");

            migrationBuilder.DropTable(
                name: "Guilds");
        }
    }
}
