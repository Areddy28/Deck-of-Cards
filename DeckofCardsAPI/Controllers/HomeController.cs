using DeckofCardsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckofCardsAPI.Controllers
{
    public class HomeController : Controller
    {
        DeckofCardsDAL dc = new DeckofCardsDAL(); 

        public IActionResult Index()
        {
            NewDeck nd = new NewDeck();
            nd = dc.GetCards();
            DrawCards d = new DrawCards();
            d = dc.drawCards(nd.deck_id);
            return View(d);
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
