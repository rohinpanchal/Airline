using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Airline.Data;
using Airline.ModelClass;

namespace Airline.Pages.ParkingSlot
{
    public class DetailsModel : PageModel
    {
        private readonly Airline.Data.AirlineContext _context;

        public DetailsModel(Airline.Data.AirlineContext context)
        {
            _context = context;
        }

        public Parking Parking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parking = await _context.Parking.FirstOrDefaultAsync(m => m.id == id);

            if (Parking == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
