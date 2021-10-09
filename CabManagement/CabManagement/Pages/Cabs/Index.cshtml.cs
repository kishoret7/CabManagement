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
    public class IndexModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public IndexModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public IList<Cab> Cab { get;set; }

        public async Task OnGetAsync()
        {
            Cab = await _context.Cab.ToListAsync();
        }
    }
}
