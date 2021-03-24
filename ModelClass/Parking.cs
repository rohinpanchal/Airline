using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.ModelClass
{
    public class Parking
    {
        public int id { get; set; }

        [Display(Name = "CustomerID")]
        public int customerID { get; set; }

        [Display(Name = "PlanID")]
        public int planID { get; set; }




        [Display(Name = "ParkID")]
        public int parkID { get; set; }

    }
}
