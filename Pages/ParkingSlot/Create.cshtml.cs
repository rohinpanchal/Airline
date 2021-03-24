using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Airline.Data;
using Airline.ModelClass;

namespace Airline.Pages.ParkingSlot
{
    public class CreateModel : PageModel
    {
        private readonly Airline.Data.AirlineContext _context;

        public CreateModel(Airline.Data.AirlineContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Parking Parking { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Parking.Add(Parking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
