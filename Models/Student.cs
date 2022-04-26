using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Student
    {
        public int ID { get; set; }
        [StringLength(10)]
        public string StudentID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int? AcquiredCredits { get; set; }
        public int? CurrentSemestar { get; set; }
        [StringLength(25)]
        public string? EducationLevel { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }  //many-to-many
    }
}
