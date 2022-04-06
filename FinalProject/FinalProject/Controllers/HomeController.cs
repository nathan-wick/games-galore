using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private GameContext context { get; set; }
        private List<Genre> genres { get; set; }
        private List<Platform> platforms { get; set; }
        private List<Publisher> publishers { get; set; }

        public HomeController(GameContext context)
        {
            this.context = context;
            genres = context.Genres.OrderBy(g => g.GenreName).ToList();
            publishers = context.Publishers.OrderBy(p => p.PublisherName).ToList();
            platforms = context.Platforms.OrderBy(p => p.PlatformName).ToList();
        }

        public IActionResult Index()
        {
            var games = context.Games
                .Include(g => g.GameGenre)
                .Include(g => g.GamePlatform)
                .Include(g => g.GamePublisher)
                .OrderBy(g => g.GameName).ToList();
            return View(games);
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GiveGame()
        {
            return View(new GameViewModel { Genres = genres, Publishers = publishers, Platforms = platforms });
        }

        [HttpPost]
        public IActionResult GiveGame(GameViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Games.Add(model.CurrentGame);
                context.SaveChanges();
                return RedirectToAction("Index");
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
        public ViewResult GetGame(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public RedirectToActionResult GetGame(Game game)
        {
            context.Remove(game);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult WickNM()
        {
            return View();
        }

        public IActionResult AdkinsDK()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
