using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Bills
{
    public class DetailsModel : PageModel
    {
        private readonly CabManagement.Data.CabManagementContext _context;

        public DetailsModel(CabManagement.Data.CabManagementContext context)
        {
            _context = context;
        }

        public Bill Bill { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bill = await _context.Bill
                .Include(b => b.Cab)
                .Include(b => b.Route).FirstOrDefaultAsync(m => m.BillId == id);

            if (Bill == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
