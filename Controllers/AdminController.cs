using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Paw_Day_Care.Controllers
{
    [Authorize(Roles = "Admin")]// This will restrict this controller to admin users only.
    public class AdminController : Controller
    {
        public IActionResult AdminDashboard()
        {
            return View();
        }
    }
}
