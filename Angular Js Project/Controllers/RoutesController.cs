using Angular_Js_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Controllers
{
    public class RoutesController : Controller
    {
        private IPassengerRepository _passengerRepository;
        public RoutesController(IPassengerRepository passengerRepository)
        {
            this._passengerRepository = passengerRepository;
        }
        public IActionResult Index()
        {
            return View(_passengerRepository.GetAllRoute());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Route obj)
        {
            if (ModelState.IsValid)
            {
                Route route = new Route
                {
                    RouteName = obj.RouteName,
                };
                _passengerRepository.SaveRoute(route);
            }
            return RedirectToAction("Index", _passengerRepository.GetAllRoute());
        }
    }
}
