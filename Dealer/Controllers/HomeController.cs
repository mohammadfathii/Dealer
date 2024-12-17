using Dealer.Data;
using Dealer.Models;
using Dealer.Models.ViewModels;
using Dealer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dealer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDealerRepository _dealerRepository;
        private readonly ICityRepository _cityRepository;

        public HomeController(ILogger<HomeController> logger,IDealerRepository dealerRepository,ICityRepository cityRepository)
        {
            _logger = logger;
            _dealerRepository = dealerRepository;
            _cityRepository = cityRepository;
        }

        public IActionResult Index()
        {
            var dealers = _dealerRepository.Get();
            var cities = _cityRepository.Get();

            return View(new HomeViewModel()
            {
                Dealers = dealers,
                Cities = cities
            });
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
