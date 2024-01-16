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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Architect company)
        {
            
            if (ModelState.IsValid)
            {
                    
                company.ArchitectId = Guid.NewGuid().ToString(); 
                await _appDbContext.Architects.AddAsync(company);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Architect");
                
            }
                
            return View(company);

        }

        public IActionResult Edit(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Architect? company = _appDbContext.Architects.FirstOrDefault(u => u.ArchitectId == id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(Architect company)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Architects.Update(company);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index", "Architect");
            }
            return View(company);

        }

        public IActionResult Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Architect? company = _appDbContext.Architects.FirstOrDefault(u => u.ArchitectId == id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(string? id)
        {
            Architect? company = _appDbContext.Architects.FirstOrDefault(u => u.ArchitectId == id);
            if (company == null)
            {
                return NotFound();
            }
            _appDbContext.Architects.Remove(company);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Architect");



        }
    }
}
