using ApteConsultancy.DataAccess.Data;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientController : Controller
    {   
        private readonly AppDbContext _appDbContext;
        public ClientController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<Client> clients = await _appDbContext.Clients.ToListAsync();
            return View(clients);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] 
        public async Task<IActionResult> Create(Client client)
        {
            if (ModelState.IsValid)
            {
                client.ClientId = Guid.NewGuid().ToString();
                await _appDbContext.Clients.AddAsync(client);
                await _appDbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Client");
            }

            return View(client);
        }

        public async Task<IActionResult> Edit(string? id)
        {
            if(id ==  null)
            {
                return NotFound();
            }
            Client? client = await _appDbContext.Clients.FirstOrDefaultAsync(u => u.ClientId == id);
            if(client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Clients.Update(client);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index", "Client");
            }
            return View(client);
        }

        public async Task<IActionResult> Delete(string? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            Client? client = await _appDbContext.Clients.FirstOrDefaultAsync();
            if(client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePOST(string? id)
        {
            Client? client = await _appDbContext.Clients.FirstOrDefaultAsync(u => u.ClientId == id);
            if(client == null)
            {
                return NotFound();
            }
            _appDbContext.Clients.Remove(client);
            await _appDbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Client");
        }

    }
}
