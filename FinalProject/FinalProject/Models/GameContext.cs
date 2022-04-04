using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Platform>().HasData(
                new Platform { PlatformId = "playstation", PlatformName = "Playstation"},
                new Platform { PlatformId = "nintendo", PlatformName = "Nintendo" },
                new Platform { PlatformId = "xbox", PlatformName = "Xbox" },
                new Platform { PlatformId = "windows", PlatformName = "Windows" },
                new Platform { PlatformId = "mac", PlatformName = "Mac" },
                new Platform { PlatformId = "linux", PlatformName = "Linux" },
                new Platform { PlatformId = "android", PlatformName = "Android" },
                new Platform { PlatformId = "ios", PlatformName = "iOS" }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "shooter", GenreName = "Shooter" },
                new Genre { GenreId = "action_adventure", GenreName = "Action/Adventure" },
                new Genre { GenreId = "simulation", GenreName = "Simulation" },
                new Genre { GenreId = "racing", GenreName = "Racing" },
                new Genre { GenreId = "sports", GenreName = "Sports" },
                new Genre { GenreId = "strategy_puzzle", GenreName = "Strategy/Puzzle" }
            );
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherId = "sony", PublisherName = "Sony" },
                new Publisher { PublisherId = "nintendo", PublisherName = "Nintendo" },
                new Publisher { PublisherId = "microsoft", PublisherName = "Microsoft" },
                new Publisher { PublisherId = "activision_blizzard", PublisherName = "Activision Blizzard" },
                new Publisher { PublisherId = "electronic_arts", PublisherName = " Electronic Arts" },
                new Publisher { PublisherId = "tencent", PublisherName = "Tencent" },
                new Publisher { PublisherId = "bethesda", PublisherName = "Bethesda Softworks" },
                new Publisher { PublisherId = "fireproof", PublisherName = "Fireproof Studios" },
                new Publisher { PublisherId = "square_enix", PublisherName = "Square Enix" }
            );
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    GameName = "Destiny 2",
                    GameReleaseDate = new System.DateTime(2017, 9, 6),
                    GamePlatformId = "xbox",
                    GameGenreId = "shooter",
                    GamePublisherId = "activision_blizzard"
                },
                new Game
                {
                    GameId = 2,
                    GameName = "The Elder Scrolls V: Skyrim",
                    GameReleaseDate = new System.DateTime(2011, 11, 11),
                    GamePlatformId = "windows",
                    GameGenreId = "action_adventure",
                    GamePublisherId = "bethesda"
                },
                new Game
                {
                    GameId = 3,
                    GameName = "The Legend of Zelda: Breath of the Wild",
                    GameReleaseDate = new System.DateTime(2017, 3, 3),
                    GamePlatformId = "nintendo",
                    GameGenreId = "action_adventure",
                    GamePublisherId = "nintendo"
                },
                new Game
                {
                    GameId = 4,
                    GameName = "Need for Speed: Hot Pursuit",
                    GameReleaseDate = new System.DateTime(2017, 3, 3),
                    GamePlatformId = "playstation",
                    GameGenreId = "racing",
                    GamePublisherId = "electronic_arts"
                },
                new Game
                {
                    GameId = 5,
                    GameName = "FIFA 21",
                    GameReleaseDate = new System.DateTime(2020, 10, 5),
                    GamePlatformId = "playstation",
                    GameGenreId = "sports",
                    GamePublisherId = "electronic_arts"
                },
                new Game
                {
                    GameId = 6,
                    GameName = "The Sims",
                    GameReleaseDate = new System.DateTime(2020, 10, 5),
                    GamePlatformId = "linux",
                    GameGenreId = "simulation",
                    GamePublisherId = "electronic_arts"
                },
                new Game
                {
                    GameId = 7,
                    GameName = "PUBG Mobile",
                    GameReleaseDate = new System.DateTime(2018, 2, 9),
                    GamePlatformId = "android",
                    GameGenreId = "shooter",
                    GamePublisherId = "tencent"
                },
                new Game
                {
                    GameId = 8,
                    GameName = "The Room: Three",
                    GameReleaseDate = new System.DateTime(2018, 2, 9),
                    GamePlatformId = "ios",
                    GameGenreId = "strategy_puzzle",
                    GamePublisherId = "fireproof"
                },
                new Game
                {
                    GameId = 9,
                    GameName = "Spider-Man",
                    GameReleaseDate = new System.DateTime(2018, 9, 7),
                    GamePlatformId = "playstation",
                    GameGenreId = "action_adventure",
                    GamePublisherId = "sony"
                },
                new Game
                {
                    GameId = 10,
                    GameName = "Shadow of the Tomb Raider",
                    GameReleaseDate = new System.DateTime(2018, 9, 12),
                    GamePlatformId = "mac",
                    GameGenreId = "action_adventure",
                    GamePublisherId = "square_enix"
                });
        }
    }
}
