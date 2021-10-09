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
    public class DetailsModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public DetailsModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public Route Route { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Route = await _context.Route
                .Include(ah => ah.Bills).FirstOrDefaultAsync(m => m.RouteId == id);

           

            if (Route == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
