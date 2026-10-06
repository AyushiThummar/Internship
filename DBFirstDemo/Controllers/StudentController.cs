using Microsoft.AspNetCore.Mvc;
using DBFirstDemo.Models;
namespace DBFirstDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly TestDbContext context;
        public StudentController(TestDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
