using MultiModelDemo.Models;
namespace MultiModelDemo.ViewModels
{
    public class CourseWiseStudent
    {
        public Course crsDetails { get; set; }
        public List<Student> stuDetails { get; set; } = new List<Student>();
    }
}
