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
    public class IndexModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public IndexModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public IList<Route> Route { get;set; }

        public async Task OnGetAsync()
        {
            Route = await _context.Route
                .Include(r => r.Cab).ToListAsync();
        }
    }
}
