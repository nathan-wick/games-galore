using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter the game's name.")]
        public string GameName { get; set; }

        [Required(ErrorMessage = "Please enter the game's release date.")]
        public DateTime? GameReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter the game's platform.")]
        public string GamePlatformId { get; set; }
        public Platform GamePlatform { get; set; }

        [Required(ErrorMessage = "Please enter the game's genre.")]
        public string GameGenreId { get; set; }
        public Genre GameGenre { get; set; }

        [Required(ErrorMessage = "Please enter the game's publisher.")]
        public string GamePublisherId { get; set; }
        public Publisher GamePublisher { get; set; }
    }
}
