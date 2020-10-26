using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Degree_Map.Models
{
    public class Course
    {
        public string CourseID { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Grade { get; set; }
        public List<Course> Prereqs { get; set; }
        public List<Course> Coreqs { get; set; }


    }
}
