using ContosoUniversity2.Data;
using ContosoUniversity2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ContosoUniversity2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ContosoUniversity2Context _context;
        public HomeController(ILogger<HomeController> logger, ContosoUniversity2Context context)
        {
            _logger = logger;
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Courses()
        {
            return View(await _context.Courses.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> StudentsAsync()
        {
            var students = await _context.Students.ToListAsync(); // Make sure to fetch the students

            return View(students);
        }

        public IActionResult Instructors()
        {
            return View();
        }

        public IActionResult Departments()
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
