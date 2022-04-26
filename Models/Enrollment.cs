using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{   

    public enum Grade
    {
        A, B, C, D, E, F
    }
    public class Enrollment
    {
        public int ID { get; set; }
        public Course CourseID { get; set; }   //nadvoresen kluc kon kurs
        public Student StudentID { get; set; }  //nadvoresen kluc kon student
        public string? Semester { get; set; }
        public int? Year { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]   //dokolku e null mi pokazuva no grade, ne e staveno vo baranjeto
        public Grade? Grade { get; set; }
        public string? SeminalUrl { get; set; }
        public string? ProjectUrl { get; set; }
        public int? ExamPoints { get; set; }
        public int? SeminalPoints { get; set; }

        public int? ProjectPoints { get; set; }
        public int? AdditionalPoints { get; set; }

        public DateTime? FinishDate { get; set; }
    }
}
