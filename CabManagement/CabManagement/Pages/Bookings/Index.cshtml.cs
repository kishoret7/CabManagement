using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Bookings
{
    public class IndexModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public IndexModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public IList<Booking> Booking { get;set; }

        public async Task OnGetAsync()
        {
            Booking = await _context.Booking
                .Include(b => b.Cab).ToListAsync();
        }
    }
}
