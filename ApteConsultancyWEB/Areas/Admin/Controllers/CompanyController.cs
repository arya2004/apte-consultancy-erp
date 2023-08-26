using ApteConsultancy.DataAccess.Data;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Mvc;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CompanyController : Controller
    {
       
        private readonly AppDbContext _appDbContext;
        public CompanyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            List<Company> companies =  _appDbContext.Companies.ToList();
            return View(companies);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Company company)
        {  
            if(ModelState.IsValid)
            {
                _appDbContext.Companies.Add(company);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index", "Company");
            }
           return View(company);
           
        }

        public IActionResult Edit(int? id)
        {   
            if(id == null || id == 0)
            {
                return NotFound(); 
            }
            Company? company = _appDbContext.Companies.FirstOrDefault(u => u.CompanyId == id);
            if(company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Companies.Update(company);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index", "Company");
            }
            return View(company);

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Company? company = _appDbContext.Companies.FirstOrDefault(u => u.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }
            return View(company);
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Company? company = _appDbContext.Companies.FirstOrDefault(u => u.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }
            _appDbContext.Companies.Remove(company);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index", "Company");
            
          

        }
    }
}
