using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Models
{
    public class Passsenger
    {
        [Key]
        [Display(Name = "ID")]
        public int PassengerID { get; set; }


        [Display(Name = "Name")]
        [Required, MaxLength(50)]
        public string PassengerName { get; set; }


        [Display(Name = "Email")]
        [Required, MaxLength(50)]
        public string PassengerEmail { get; set; }


        [Display(Name = "Phone")]
        [Required, MaxLength(50)]
        public string PassengerPhone { get; set; }


        [Display(Name = "Journey Date")]
        [Required]
        public DateTime JourneyDate { get; set; }


        [Required]
        public int TrainID { get; set; }


        [Display(Name = "Train")]
        public string TrainName { get; set; }

        [Required]
        public int RouteID { get; set; }


        [Display(Name = "Route")]
        public string RouteName { get; set; }

        [Required]
        public int ClassID { get; set; }


        [Display(Name = "Class")]
        public string ClassName { get; set; }


        [Display(Name = "Fee")]
        [Required]
        public decimal Fee { get; set; }


        [Display(Name = "Image Url")]
        public string PhotoPath { get; set; }


        public string ExistingPhotoPath { get; set; }

        public virtual Train Train { get; set; }
        public virtual Class Class { get; set; }
        public virtual Route Route { get; set; }  
    }
}
