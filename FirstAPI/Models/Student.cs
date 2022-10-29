using System.ComponentModel.DataAnnotations;
using System.Runtime.Versioning;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace FirstAPI.Models
{
    public class Student
    {
        public int Id { get; }

        [Required(ErrorMessage = "First name must be filled.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name must be filled.")]
        public string LastName { get; set; }

        [Range(16,40)]
        public int Age { get; set; }

        public string? University { get; set; }

        [Required(ErrorMessage = "Course name must be filled.")]
        public Course? CourseName { get; set; }

        [Required(ErrorMessage ="The mail address must be filled.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number must be filled.")]
        public string Phone { get; set; }

        public string Source { get; set; }

        public byte[] CV { get; set; }

        public Student() { }
        public Student(string fname, string lname, int age, string uni, Course course, 
                        string email, string phone, string source, byte[] CV)
        {
            Id++;
            FirstName = fname;
            LastName = lname;
            Age = age;
            University = uni;
            CourseName = course;
            Email = email;
            Phone = phone;
            Source = source;
            this.CV = CV;
        }
    }
    public enum Course
    {
        CSharp,
        JavaScript,
        Html_Css,
        UI
    }
}
