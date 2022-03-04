using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade //Fixed values for Grades
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //P.K
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]//for client only
        public Grade? Grade { get; set; } //? Means Nullable

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
