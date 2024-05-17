using Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Categories;

namespace API_Ecommerce.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
