using ApteConsultancy.Models;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApteConsultancyWEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AssociateUser> _userManagerAssociate;
        private readonly UserManager<EmployeeUser> _userManagerEMpl;

        public HomeController(ILogger<HomeController> logger, UserManager<AssociateUser> userManagerAssociate, UserManager<EmployeeUser> userManagerEMpl   )
        {
            _logger = logger;
            this._userManagerAssociate = userManagerAssociate;
            this._userManagerEMpl = userManagerEMpl;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            var cusomer = new EmployeeUser() { Email = "cutomer1@hotmail.com", UserName = "Tom", EmployeeName = "Java"};

            var result = await _userManagerEMpl.CreateAsync(cusomer, "Password01!");

            var professional = new AssociateUser() { Email = "pro1@hotmail.com", UserName = "Jack", Designation2 = "CTO" };

            var result2 = await _userManagerAssociate.CreateAsync(professional, "Password01!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}