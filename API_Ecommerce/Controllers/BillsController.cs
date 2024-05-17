using Microsoft.AspNetCore.Mvc;

namespace API_Ecommerce.Controllers
{
    public class BillsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
