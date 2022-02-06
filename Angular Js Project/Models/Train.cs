using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Angular_Js_Project.Models
{
    public class Train
    {
        [Key]
        public int TrainID { get; set; }


        [Required, MaxLength(50)]
        public string TrainName { get; set; }

        public virtual ICollection<Passsenger> Passengers { get; set; }
    }
}
