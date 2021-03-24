using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airline.Data;
using Airline.ModelClass;

namespace Airline.Pages.ClientPayment
{
    public class IndexModel : PageModel
    {
        private readonly Airline.Data.AirlineContext _context;

        public IndexModel(Airline.Data.AirlineContext context)
        {
            _context = context;
        }

        public IList<Payment> Payment { get;set; }

        public async Task OnGetAsync()
        {
            Payment = await _context.Payment.ToListAsync();
        }
    }
}
