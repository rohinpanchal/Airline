using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airline.ModelClass
{
    public class Payment
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Payment")]
        public int Paymnt { get; set; }


        [Display(Name = "payment Date")]
        public string paymentDate { get; set; }

    }
}
