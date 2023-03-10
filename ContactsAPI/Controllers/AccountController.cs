using Microsoft.AspNetCore.Mvc;

namespace ContactsAPI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
