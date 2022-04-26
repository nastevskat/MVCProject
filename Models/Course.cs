using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Course
    {

        public int ID { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public int Credits { get; set; }
        public int Semester { get; set; }
        [StringLength(100)]
        public string? Programme { get; set; }
        [StringLength(25)]
        public string? EducationalLevel { get; set; }
        public Teacher? FirstTeacherID { get; set; }
        public Teacher? SecondTeacherID { get; set; }


    }
}
