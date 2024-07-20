using Microsoft.AspNetCore.Mvc;

namespace StoreApp.Areas.Admin.Controllers
{
    [Area("Admin")] // This is the area name which is used to identify the controllers in the Admin area
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
