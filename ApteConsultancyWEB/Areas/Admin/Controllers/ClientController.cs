using Microsoft.AspNetCore.Mvc;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
