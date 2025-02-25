using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Models;

namespace LeaveManagementSystem.Controllers
{
    public class TestController : Controller
    {
        // GET: TestController
        public ActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "John Doe",
                DateOfBirth = new DateTime(1980, 1, 1),
                Address = "123 Elm St",
                City = "Springfield",
            };

            return View(data);
        }

    }
}
