using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalProject.Controllers
{
    public class GameController : Controller
    {
        private GameContext context { get; set; }
        private List<Genre> genres { get; set; }
        private List<Platform> platforms { get; set; }
        private List<Publisher> publishers { get; set; }

        public GameController(GameContext context)
        {
            this.context = context;
            genres = context.Genres.OrderBy(g => g.GenreName).ToList();
            publishers = context.Publishers.OrderBy(p => p.PublisherName).ToList();
            platforms = context.Platforms.OrderBy(p => p.PlatformName).ToList();
        }

        public IActionResult Games()
        {
            var games = context.Games
                .Include(g => g.GameGenre)
                .Include(g => g.GamePlatform)
                .Include(g => g.GamePublisher)
                .OrderBy(g => g.GameName).ToList();
            return View(games);
        }

        [HttpGet]
        public IActionResult Donate()
        {
            return View(new GameViewModel { Genres = genres, Publishers = publishers, Platforms = platforms });
        }

        [HttpPost]
        public IActionResult Donate(GameViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Games.Add(model.CurrentGame);
                context.SaveChanges();
                return RedirectToAction("Games");
            }
            else
            {
                model.Genres = genres;
                model.Publishers = publishers;
                model.Platforms = platforms;
                return View(model);
            }
        }

        [HttpGet]
        public ViewResult Checkout(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public RedirectToActionResult Checkout(Game game)
        {
            context.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
