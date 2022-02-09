using MaciejLendzionLab4ZadDom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MaciejLendzionLab4ZadDom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        // wszystkie posiłki do wyświetlenia w menu
        List<MealViewModel> allMeals;
        List<RateViewModel> allRates;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            allMeals = new List<MealViewModel>();
            allMeals.Add(new MealViewModel("Knysza", "bułka, sałata lodowa, sosy, mięso wołowe, pomidor, ogórek", "Tradycyjna knysza", 16,"knysza.png"));
            allMeals.Add(new MealViewModel("Pita ", "chlebek pita, sałata lodowa, sałata czerwona,sosy, mięso wołowe, pomidor, ogórek", "Pita podawana w tradycyjnym chlebku", 18, "pita.png"));
            allMeals.Add(new MealViewModel("Frytki", "solone frytki, sos do wyboru", "Świetny dodatek do każdego dania", 16, "fries.png"));

            allRates = new List<RateViewModel>();
            allRates.Add(new RateViewModel("Benek", "Najlepszy kebab w internecie!"));
            allRates.Add(new RateViewModel("Zenek", "Nigdy czegoś takiego nie jadłem, jest świetny!"));
            allRates.Add(new RateViewModel("Gienek", "Nieporównywalnie dobry!"));
            allRates.Add(new RateViewModel("Fredek", "10/10!"));


        }

        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Order(OrderViewModel order)
        {
            string meal = order.Meal;
            string drink = order.Drink;
            string extra = order.Extra;

            ViewBag.Meal = meal;
            ViewBag.Drink = drink; 
            ViewBag.Extra = extra;


            return View("OrderConfirm");
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Rates()
        {
            return View(allRates);
        }

        /// <summary>
        /// Pobranie od użytkownika recenzji
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateRate()
        {
            return View();
        }



        /// <summary>
        /// Post dla stworzenia recenzji
        /// </summary>
        /// <param name="rate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateRate(RateViewModel rate)
        {
            string name = rate.Name;
            string opinion = rate.Opinion;
            allRates.Add(new RateViewModel(name, opinion));
            ViewBag.Name = name;
            ViewBag.Opinion = opinion;
            
            //komunikat zwrotny
            return View("CreateRateSuccess");
        }

        /// <summary>
        /// Strona kontaktowa, wprowadzenie dancyh do formularza
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Strona kontaktowa, wysłanie formularza
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Contact(ContactViewModel contact)
        {
            ViewBag.FirstName = contact.FirstName;
            ViewBag.LastName = contact.LastName;
            ViewBag.Mail = contact.Mail;
            ViewBag.Message = contact.Message;
            return View("ContactSuccess");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// Menu dań
        /// </summary>
        /// <returns></returns>
        public IActionResult Menu()
        {
            return View(allMeals);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
