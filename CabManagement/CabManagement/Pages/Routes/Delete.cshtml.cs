using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Routes
{
    public class DeleteModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public DeleteModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Route Route { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Route = await _context.Route
                .Include(r => r.Cab).FirstOrDefaultAsync(m => m.RouteId == id);

            if (Route == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Route = await _context.Route.FindAsync(id);

            if (Route != null)
            {
                _context.Route.Remove(Route);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
