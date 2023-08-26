using ApteConsultancy.DataAccess.Data;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Mvc;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArchitectController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public ArchitectController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            List<Architect> architects = _appDbContext.Architects.ToList();
            return View(architects);
        }
    }
}
