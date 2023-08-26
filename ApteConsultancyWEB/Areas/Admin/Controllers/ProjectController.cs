using Microsoft.AspNetCore.Mvc;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
