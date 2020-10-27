using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Degree_Map.Models
{
    public class SemesterPlan
    {
        public int SemesterPlanId { get; set; }

        public List<string> CoursesID { get; set; }
        public List<Course> Courses { get; set; }


    }
}
