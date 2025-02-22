using Microsoft.AspNetCore.Mvc;

namespace EmployeManagementSystem.Controllers
{
    [Route("/Register")]public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
