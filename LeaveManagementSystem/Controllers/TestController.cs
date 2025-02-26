using LeaveManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {

            var data = new TestViewModel
            {
                Name = "Jonah",
                Age = 25,
                DateOfBirth = new DateTime(1996, 1, 1),
                Address = "123 Main St, Springfield, IL",
                Email = "jonah.uka@gmail.com",

            };
            return View(data);
        }

    }
}
