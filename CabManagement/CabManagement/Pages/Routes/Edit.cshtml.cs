using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Routes
{
    public class EditModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public EditModel(CabManagement.Data.CabManagementContext context)
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
           ViewData["CabId"] = new SelectList(_context.Cab, "CabId", "CabId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Route).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RouteExists(Route.RouteId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RouteExists(int id)
        {
            return _context.Route.Any(e => e.RouteId == id);
        }
    }
}
