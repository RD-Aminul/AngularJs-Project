using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "The page you are looking for does not Exists";
                    break;
                default:
                    ViewBag.ErrorMessage = "Some problem occured. Please contact system admin.";
                    break;
            }
            return View("Error");
        }
    }
}
