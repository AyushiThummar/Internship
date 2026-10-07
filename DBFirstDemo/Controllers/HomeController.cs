using System.Diagnostics;
using DBFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TestDbContext context;
        public HomeController(ILogger<HomeController> logger,TestDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Student> students = context.Students.ToList();
            return View(students);
        }
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                Student? st = context.Students.FirstOrDefault(item => item.Roll == id);
                if (st != null)
                {
                    return View(st);
                }
                else
                {
                    TempData["message"] = "Record not found for roll : " + id;
                    return RedirectToAction("List");
                }
            }
            TempData["message"] = "Please pass roll to search information : ";
            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student stu)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    context.Students.Add(stu);
                    context.SaveChanges();
                    TempData["success"] = "Record inserted successfully for roll : " + stu.Roll;
                }
                catch (Exception)
                {
                    TempData["message"] = "Error while inserting record for roll : " + stu.Roll + " Error : Try to check if you entered existing roll number";
                }
                return RedirectToAction("List");
            }
            return View(stu);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                Student? st = context.Students.FirstOrDefault(item => item.Roll == id);
                if(st != null)
                {
                    return View(st);
                }
                else
                {
                    TempData["message"] = "Record not found for roll : " + id;
                    return RedirectToAction("List");
                }
            }
            TempData["message"] = "Please pass roll to edit data.. ";
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Edit(Student stu)
        {
            if (ModelState.IsValid)
            {
                context.Students.Update(stu);
                context.SaveChanges();
                TempData["success"] = "Record updated successfully for roll : " + stu.Roll;
                return RedirectToAction("List");
            }
            return View(stu);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Student? stu = context.Students.FirstOrDefault(item => item.Roll == id);
                if (stu != null)
                {
                    return View(stu);
                }
                else
                {
                    TempData["message"] = "Record not found for roll : " + id;
                    return RedirectToAction("List");
                }
            }
            TempData["message"] = "Please pass roll to delete data.. ";
            return RedirectToAction("List");
        }
        [HttpPost]
        public IActionResult Delete(Student stu)
        {
            if (stu != null)
            {
                context.Students.Remove(stu);
                context.SaveChanges();
                TempData["success"] = "Data deleted successfully.";
                return RedirectToAction("List");       
            }
            TempData["message"] = "Unable to delete data..";
            return RedirectToAction("List");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
