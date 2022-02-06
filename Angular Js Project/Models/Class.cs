using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Models
{
    public class Class
    {
        [Key]
        public int ClassID { get; set; }


        [Required, MaxLength(50)]
        public string ClassName { get; set; }

        public virtual ICollection<Passsenger> Passengers { get; set; }
    }
}
