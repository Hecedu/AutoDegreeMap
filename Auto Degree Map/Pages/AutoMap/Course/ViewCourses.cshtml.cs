using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Auto_Degree_Map.Models;

namespace Auto_Degree_Map.Pages.AutoMap
{
    public class ViewCoursesModel : PageModel
    {
        private readonly Auto_Degree_Map.Models.ApplicationDbContext _context;

        public ViewCoursesModel(Auto_Degree_Map.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Courses.ToListAsync();
        }
    }
}
