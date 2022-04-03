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
                new Platform { PlatformId = "linux", PlatformName = "Linux" }
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
                new Publisher { PublisherId = "tencent", PublisherName = "Tencent" }
            );
        }
    }
}
