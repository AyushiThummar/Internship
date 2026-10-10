using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MultiModelDemo.Models;
using MultiModelDemo.ViewModels;

namespace MultiModelDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentInfoDbContext context;
        public HomeController(ILogger<HomeController> logger, StudentInfoDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Search(int? id)
        {
            if (id != null)
            {
                CourseWiseStudent cws = new CourseWiseStudent();
                cws.crsDetails = context.Courses.FirstOrDefault(item => item.CourseId == id);
                if(cws.crsDetails != null)
                {
                    cws.stuDetails = context.Students.Where(item => item.CourseId == id).ToList();
                    return View(cws);
                }
                else
                {
                    TempData["error"] = "Invalid course ID.";
                    return RedirectToAction("Index"); 
                }
            }
            TempData["error"]= "Please enter a course ID to search.";
            return RedirectToAction("Index");
        }

        public IActionResult SearchStu(int? id)
        {
            StudentWithFee sws = new StudentWithFee();
            if (id != null)
            {
                sws.stuDetails = context.Students.FirstOrDefault(item => item.StuId == id);
                if(sws.stuDetails != null)
                {
                    sws.feeDetails = context.Fees.Where(item => item.StuId == id).ToList();
                    return View(sws);
                }
                else
                {
                    TempData["error"] = "Details not found for this student ID.";
                    return RedirectToAction("Index");
                }
            }
            TempData["error"] = "Please enter a student ID to search.";
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
