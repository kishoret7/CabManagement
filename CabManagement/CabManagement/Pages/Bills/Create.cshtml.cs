﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CabManagement.Data;
using CabManagement.Models;

namespace CabManagement.Pages.Bills
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
        ViewData["RouteId"] = new SelectList(_context.Set<Route>(), "RouteId", "RouteId");
            return Page();
        }

        [BindProperty]
        public Bill Bill { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Bill.Add(Bill);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
