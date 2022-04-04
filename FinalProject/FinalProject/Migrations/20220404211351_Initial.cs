using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GamePlatformId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GameGenreId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GamePublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GameGenreId",
                        column: x => x.GameGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Platforms_GamePlatformId",
                        column: x => x.GamePlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Games_Publishers_GamePublisherId",
                        column: x => x.GamePublisherId,
                        principalTable: "Publishers",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { "shooter", "Shooter" },
                    { "action_adventure", "Action/Adventure" },
                    { "simulation", "Simulation" },
                    { "racing", "Racing" },
                    { "sports", "Sports" },
                    { "strategy_puzzle", "Strategy/Puzzle" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "PlatformId", "PlatformName" },
                values: new object[,]
                {
                    { "ios", "iOS" },
                    { "android", "Android" },
                    { "mac", "Mac" },
                    { "linux", "Linux" },
                    { "xbox", "Xbox" },
                    { "nintendo", "Nintendo" },
                    { "playstation", "Playstation" },
                    { "windows", "Windows" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PublisherId", "PublisherName" },
                values: new object[,]
                {
                    { "fireproof", "Fireproof Studios" },
                    { "sony", "Sony" },
                    { "nintendo", "Nintendo" },
                    { "microsoft", "Microsoft" },
                    { "activision_blizzard", "Activision Blizzard" },
                    { "electronic_arts", " Electronic Arts" },
                    { "tencent", "Tencent" },
                    { "bethesda", "Bethesda Softworks" },
                    { "square_enix", "Square Enix" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "GameGenreId", "GameName", "GamePlatformId", "GamePublisherId", "GameReleaseDate" },
                values: new object[,]
                {
                    { 9, "action_adventure", "Spider-Man", "playstation", "sony", new DateTime(2018, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "action_adventure", "The Legend of Zelda: Breath of the Wild", "nintendo", "nintendo", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "shooter", "Destiny 2", "xbox", "activision_blizzard", new DateTime(2017, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "racing", "Need for Speed: Hot Pursuit", "playstation", "electronic_arts", new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "sports", "FIFA 21", "playstation", "electronic_arts", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "simulation", "The Sims", "linux", "electronic_arts", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "shooter", "PUBG Mobile", "android", "tencent", new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "action_adventure", "The Elder Scrolls V: Skyrim", "windows", "bethesda", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "strategy_puzzle", "The Room: Three", "ios", "fireproof", new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "action_adventure", "Shadow of the Tomb Raider", "mac", "square_enix", new DateTime(2018, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameGenreId",
                table: "Games",
                column: "GameGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GamePlatformId",
                table: "Games",
                column: "GamePlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GamePublisherId",
                table: "Games",
                column: "GamePublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
