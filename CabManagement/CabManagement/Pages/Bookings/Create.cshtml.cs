using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Bookings
{
    public class CreateModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public CreateModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CabId"] = new SelectList(_context.Set<Cab>(), "CabId", "CabId");
            return Page();
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Booking.Add(Booking);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
