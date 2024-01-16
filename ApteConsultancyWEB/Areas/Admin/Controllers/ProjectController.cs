using ApteConsultancy.DataAccess.Data;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ProjectController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {   
            List<Project>? projects =  _appDbContext.Projects.ToList();
            return View(projects);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Project project)
        {
            if (ModelState.IsValid)
            {
                project.ProjectId = Guid.NewGuid().ToString();
                await _appDbContext.Projects.AddAsync(project);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Project");

            }

            return View(project);
        }

        public async Task<IActionResult> Edit(string? id)
        {
            if (id ==  null)
            {
                return NotFound();
            }
            Project? project = await _appDbContext.Projects.FirstOrDefaultAsync(u => u.ProjectId == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Projects.Update(project);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Project");

            }
            return View(project);
        }

        public async  Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            Project? project = await _appDbContext.Projects.FirstOrDefaultAsync (u => u.ProjectId == id);
            if(project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePOST(string? id)
        {
            Project? project = await _appDbContext.Projects.FirstOrDefaultAsync (_ => _.ProjectId == id);
            if( project == null)
            {
                return NotFound();
            }
            _appDbContext.Projects.Remove(project);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Project");
        }
    }
}
