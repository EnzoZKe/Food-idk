using Microsoft.AspNetCore.Mvc;
using App.Filters;

namespace Produtos_Com_Admin.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]

        public IActionResult Index()
        {
            return View();
        }
    }
}