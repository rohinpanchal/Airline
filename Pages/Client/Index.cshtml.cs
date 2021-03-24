using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airline.Data;
using Airline.ModelClass;

namespace Airline.Pages.Client
{
    public class IndexModel : PageModel
    {
        private readonly Airline.Data.AirlineContext _context;

        public IndexModel(Airline.Data.AirlineContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
