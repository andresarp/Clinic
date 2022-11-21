using Clinica.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Clinica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       // IServiceProvider _serviceProvider;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*
        public async Task<IActionResult> Index()
        {
           // await CreateRolesAsync(_serviceProvider);
            return View();
        }
        */

        public IActionResult Index()
        {
            _logger.LogInformation("Home Controller Invoked"); 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task CreateRolesAsync(IServiceProvider serviceProvider) {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            String[] specialtyName = { "Mediciona general", "Geriatría", "Oftalmología", "Urología", "Oncología", "ginecología" };
            foreach (var specialty in specialtyName)
            {
                var specialtyExist = await roleManager.RoleExistsAsync(specialty);
                if (!specialtyExist) {
                    await roleManager.CreateAsync(new IdentityRole(specialty));
                }

            }
        }
    }
}