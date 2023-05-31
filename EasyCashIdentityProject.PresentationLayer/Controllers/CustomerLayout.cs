using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class CustomerLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
