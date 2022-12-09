using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeHealthy.Controllers
{
    public class ProfileController : Controller
    {
        // GET: ProfileController
        public IActionResult Index()
        {
            return View();
        }

    }
}
