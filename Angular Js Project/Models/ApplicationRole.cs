using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Models
{
    public class ApplicationRole : IdentityRole
    {
        [Display(Name = "Controller")]
        public string ControllerName { get; set; }

        [Display(Name = "Action")]
        public string ActionName { get; set; }

        public ApplicationRole() : base() { }

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string controllerName, string actionName) : base(roleName)
        {
            base.Name = roleName;
            this.ControllerName = controllerName;
            this.ActionName = actionName;
        }
    }
}
