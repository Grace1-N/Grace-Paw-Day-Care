using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Paw_Day_Care.Controllers
{
    public class UserController : Controller
    {
        [Authorize]// Ensures that only loged in users can access this controller 
        public IActionResult UserDashboard()
        {
            return View();
        }
    }
}
