using Microsoft.AspNetCore.Mvc;

namespace testproject.Controllers.student
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
