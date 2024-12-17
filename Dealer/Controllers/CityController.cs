using Dealer.Models;
using Dealer.Models.ViewModels;
using Dealer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dealer.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IActionResult Create()
        {
            return View(new CreateCityViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreateCityViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var city = new City()
            {
                Code = model.Code,
                Name = model.Name,
            };

            _cityRepository.Create(city);

            return Redirect("/");
        }
    }
}
