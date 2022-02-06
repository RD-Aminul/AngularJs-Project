using Angular_Js_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.ViewModels
{
    public class PassengerViewModel
    {
        [Display(Name = "ID")]
        [Key]
        public int PassengerID { get; set; }


        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter Passenger Name")]
        [DataType(DataType.Text)]
        public string PassengerName { get; set; }


        //[ValidEmailDomain(allowedDomain: "gmail.com", ErrorMessage = "Email domain must be gmail.com")]
        //[Remote(action: "IsEmailInUse", controller: "Passenger")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter Passenger Email")]
        [DataType(DataType.EmailAddress)]
        public string PassengerEmail { get; set; }


        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Enter Passenger Phone")]
        public string PassengerPhone { get; set; }


        [Display(Name = "Journey Date")]
        [DataType(DataType.Text)]
        public DateTime JourneyDate { get; set; }


        [Required(ErrorMessage = "Please Select Train")]
        public int TrainID { get; set; }


        [Display(Name = "Train")]

        public string TrainName { get; set; }


        [Required(ErrorMessage = "Please Select Route")]
        public int RouteID { get; set; }


        [Display(Name = "Route")]

        public string RouteName { get; set; }



        [Required(ErrorMessage = "Please Select Class")]
        public int ClassID { get; set; }


        [Display(Name = "Class")]

        public string ClassName { get; set; }


        [Display(Name = "Fee")]
        [Required(ErrorMessage = "Enter Fee")]
        [DataType(DataType.Currency)]
        public decimal Fee { get; set; }


        [Display(Name = "Image Url")]

        public string PhotoPath { get; set; }
        public IFormFile Photo { get; set; }

        public string ExistingPhotoPath { get; set; }

    }
}
