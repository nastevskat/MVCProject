using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Teacher
    { 
        public int ID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string? Degree { get; set; }
        [StringLength(25)]
        public string? AcademicRank { get; set; }
        [StringLength(10)]
        public string? OfficeNumber { get; set; }
        public DateTime? HireDate { get; set; }

    }
}
