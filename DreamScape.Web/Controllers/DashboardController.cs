using Microsoft.AspNetCore.Mvc;

namespace DreamScape.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
