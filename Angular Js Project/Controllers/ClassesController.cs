using Angular_Js_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Controllers
{
    public class ClassesController : Controller
    {
        private IPassengerRepository _passengerRepository;
        public ClassesController(IPassengerRepository passengerRepository)
        {
            this._passengerRepository = passengerRepository;
        }
        public IActionResult Index()
        {
            return View(_passengerRepository.GetAllClass());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Class obj)
        {
            if (ModelState.IsValid)
            {
                Class cls = new Class
                {
                    ClassName = obj.ClassName,
                };
                _passengerRepository.SaveClass(cls);
            }
            return RedirectToAction("Index", _passengerRepository.GetAllClass());
        }
    }
}
