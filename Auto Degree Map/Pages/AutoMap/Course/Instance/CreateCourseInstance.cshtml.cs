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
    public class CreateCourseInstanceModel : PageModel
    {
        private readonly Auto_Degree_Map.Models.ApplicationDbContext _context;

        public CreateCourseInstanceModel(Auto_Degree_Map.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "CourseID");
            return Page();
        }

        [BindProperty]
        public CourseInstance CourseInstance { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CourseInstances.Add(CourseInstance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
