using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Degree_Map.Models
{
    public class Degree
    {
        public string Name { get; set; }
        public int RequiredCredits { get; set; }
        public List<Course> RequiredCourses { get; set; }

    }
}
