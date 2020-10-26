using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Degree_Map.Models
{
    public class CourseInstance
    {
        public string CourseInstanceID { get; set; }
        public Course Course { get; set; }
        public string Semester { get; set; }
        public string Teacher  { get; set; }

    }
}
