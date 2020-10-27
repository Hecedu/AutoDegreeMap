using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Auto_Degree_Map.Models;

namespace Auto_Degree_Map.Pages.AutoMap
{
    public class ViewCourseInstancesModel : PageModel
    {
        private readonly Auto_Degree_Map.Models.ApplicationDbContext _context;

        public ViewCourseInstancesModel(Auto_Degree_Map.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CourseInstance> CourseInstance { get;set; }

        public async Task OnGetAsync()
        {
            CourseInstance = await _context.CourseInstances
                .Include(c => c.Course).ToListAsync();
        }
    }
}
