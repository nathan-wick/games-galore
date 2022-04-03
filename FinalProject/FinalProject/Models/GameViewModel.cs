using System.Collections.Generic;

namespace FinalProject.Models
{
    public class GameViewModel
    {
        public GameViewModel()
        {
            CurrentGame = new Game();
        }
        public List<Platform> Platforms { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<Game> Games { get; set; }
        public Game CurrentGame { get; set; }
    }
}
