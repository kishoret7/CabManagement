using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Cabs
{
    public class DetailsModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public DetailsModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public Cab Cab { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Cab = await _context.Cab.FirstOrDefaultAsync(m => m.CabId == id);

            Cab = await _context.Cab
              .Include(ah => ah.Booking)
              .Include(c => c.Routes)
                  .Include(c => c.Bills).FirstOrDefaultAsync(m => m.CabId == id);

            if (Cab == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
