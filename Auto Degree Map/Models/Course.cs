using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Auto_Degree_Map.Models
{
    public class Course
    {
        public Course()
        {
            Prereqs = new List<Course>();
            Coreqs = new List<Course>();
        }

        public string CourseID { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Grade { get; set; }
        public bool Pass { get; set; }

        //list of courses
        [NotMapped]
        public List<Course> Prereqs { get; set; }
        [NotMapped]
        public List<Course> Coreqs { get; set; }


    }
}
