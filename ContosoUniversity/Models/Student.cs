using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //BaseModel
    //clase -- table
    public class Student
    {
        //P.K
        public int ID { get; set; }
        [Required (ErrorMessage ="Last Name is Required")]
        [StringLength(30,ErrorMessage ="Last Name must be less than or equal 30 chars only.")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage ="Last Name Must Be letter Starting with Upper Letter.")]
        [Display(Name ="Last Name")]

        public string LastName { get; set; }
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Display(Name ="First Name")]
        [Column("FirstName")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        //Won't create in database
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
        //navigation Properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
