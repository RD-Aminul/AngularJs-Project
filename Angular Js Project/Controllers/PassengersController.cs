using Angular_Js_Project.Models;
using Angular_Js_Project.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Angular_Js_Project.Controllers
{
    [Authorize]
    public class PassengersController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private IPassengerRepository _passengerRepository;
        public PassengersController(IPassengerRepository passengerRepository, IWebHostEnvironment hostingEnvironment)
        {
            this._passengerRepository = passengerRepository;
            this._hostingEnvironment = hostingEnvironment;
        }


        public IActionResult Index(string searchText = "", int pg = 1)
        {
            List<Passsenger> list = _passengerRepository.GetAllPassenger().ToList();

            if (searchText != "" && searchText != null)
            {
                list = _passengerRepository.GetAllPassenger().Where(p => p.PassengerName.Contains(searchText)).ToList();
            }
            else
            {
                list = _passengerRepository.GetAllPassenger().Where(p => p.PassengerName.Contains(searchText)).ToList();
            }
            const int pageSize = 3;
            if (pg < 1)
            {
                pg = 1;
            }
            int recsCount = list.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = list.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            return View(data);
        }

        [HttpGet]
        public JsonResult GetAllPassenger()
        {
            var data = _passengerRepository.GetAllPassenger();
            return Json(data, new JsonSerializerOptions());
        }

        [HttpGet]
        public JsonResult GetAllTrain()
        {
            var data = _passengerRepository.GetAllTrain();
            return Json(data, new JsonSerializerOptions());
        }

        [HttpGet]
        public JsonResult GetAllRoute()
        {
            var data = _passengerRepository.GetAllRoute();
            return Json(data, new JsonSerializerOptions());
        }

        [HttpGet]
        public JsonResult GetAllClass()
        {
            var data = _passengerRepository.GetAllClass();
            return Json(data, new JsonSerializerOptions());
        }

        [HttpPost]
        public JsonResult Create([FromBody] PassengerViewModel obj)
        {
            if (ModelState.IsValid)
            {
                //string unqueFileName = ProcessFileUpload(obj);
                Passsenger passenger = new Passsenger
                {
                    PassengerID = obj.PassengerID,
                    PassengerName = obj.PassengerName,
                    PassengerEmail = obj.PassengerEmail,
                    PassengerPhone = obj.PassengerPhone,
                    JourneyDate = obj.JourneyDate,
                    TrainID = obj.TrainID,
                    RouteID = obj.RouteID,
                    ClassID = obj.ClassID,
                    Fee = obj.Fee,
                    //PhotoPath = unqueFileName
                };
                _passengerRepository.SavePassenger(passenger);
                var psngrs = _passengerRepository.GetAllPassenger();
                return Json(psngrs, new JsonSerializerOptions());
            }
            else
            {
                ViewBag.Trains = _passengerRepository.GetAllTrain();
                ViewBag.Routes = _passengerRepository.GetAllRoute();
                ViewBag.Classes = _passengerRepository.GetAllClass();
                var psngrs = _passengerRepository.GetAllPassenger();
                return Json(psngrs, new JsonSerializerOptions());
            }
        }

        [HttpPost]
        public JsonResult Edit([FromBody] PassengerViewModel obj)
        {
            Passsenger psngrObj = _passengerRepository.GetPassengerById(obj.PassengerID);
            if (ModelState.IsValid)
            {
                psngrObj.PassengerName = obj.PassengerName;
                psngrObj.PassengerEmail = obj.PassengerEmail;
                psngrObj.PassengerPhone = obj.PassengerPhone;
                psngrObj.JourneyDate = obj.JourneyDate;
                psngrObj.TrainID = obj.TrainID;
                psngrObj.RouteID = obj.RouteID;
                psngrObj.ClassID = obj.ClassID;
                psngrObj.Fee = obj.Fee;
                Passsenger psngr = _passengerRepository.UpdatePassenger(psngrObj);
            }
            var psngrs = _passengerRepository.GetAllPassenger();
            return Json(psngrs, new JsonSerializerOptions());
        }

        [HttpPost]
        public JsonResult Delete (int id)
        {
            _passengerRepository.DeletePassenger(id);
            var psngrs = _passengerRepository.GetAllPassenger();
            return Json(psngrs, new JsonSerializerOptions());
        }

        public IActionResult _Details(int id)
        {
            Passsenger psngrObj = _passengerRepository.GetPassengerById(id);
            return View(psngrObj);
        }


    }
}
