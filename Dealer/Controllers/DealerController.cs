using Dealer.Models;
using Dealer.Models.Enums;
using Dealer.Models.ViewModels;
using Dealer.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dealer.Controllers
{
    public class DealerController : Controller
    {
        private readonly IDealerRepository _dealerRepository;
        public DealerController(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new CreateDealerViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreateDealerViewModel dealer)
        {
            if (!ModelState.IsValid)
            {
                return View(dealer);
            }
            var result = _dealerRepository.Create(new Models.Dealer()
            {
                Code = dealer.Code,
                Name = dealer.Name,
                DealerNo = dealer.DealerNo,
                Status = (Status) dealer.Status,
                CityId = dealer.CityId,
            });

            return Redirect("Index");
        }

    }
}
