using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInfoDemo.Models
{
    public class Student
    {
        [Key]
        [Required]
        [Display(Name = "Student ID")]
        [Column("stuid",TypeName = "int")]
        public int sid { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        [Column("stuname", TypeName = "varchar(100)")]
        public string? name { get; set; }


        [Required]
        [Display(Name = "Student Gender")]
        [Column("stugen", TypeName = "varchar(50)")]
        public string? gender { get; set; }

        [Required]
        [Display(Name = "Student Date of Birth")]
        [Column("studob", TypeName = "date")]
        public DateOnly dob { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Student Email")]
        [Column("stuemail", TypeName = "varchar(100)")]
        public string? email { get; set; }

        [Required]
        [Display(Name = "Student Phone")]
        [Column("stuphone", TypeName = "varchar(10)")]
        public string? phone { get; set; }

        [Required]
        [Display(Name = "Student Adhaar Number")]
        [Column("stuadhaar", TypeName = "varchar(12)")]
        public string? adhaar { get; set; }
    }
}
