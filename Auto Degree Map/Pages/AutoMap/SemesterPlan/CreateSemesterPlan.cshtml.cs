using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Auto_Degree_Map.Models;

namespace Auto_Degree_Map.Pages.AutoMap
{
    public class CreateSemesterPlanModel : PageModel
    {
        private readonly Auto_Degree_Map.Models.ApplicationDbContext _context;

        public CreateSemesterPlanModel(Auto_Degree_Map.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SemesterPlan SemesterPlan { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SemesterPlan.Add(SemesterPlan);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
