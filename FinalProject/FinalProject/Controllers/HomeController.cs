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

        public HomeController(GameContext context) => this.context = context;

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

        public IActionResult GiveGame()
        {
            return View();
        }

        public IActionResult GetGame()
        {
            return View();
        }

        public IActionResult WickNM()
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
