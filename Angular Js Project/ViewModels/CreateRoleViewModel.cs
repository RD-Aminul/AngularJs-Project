using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.ViewModels
{
    public class CreateRoleViewModel
    {
        [Display(Name = "Role")]
        [Required]
        public string RoleName { get; set; }
    }
}
