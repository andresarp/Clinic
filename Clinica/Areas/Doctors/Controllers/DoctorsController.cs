using Clinica.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Clinica.Areas.Doctors.Controllers
{
    [Area("Doctors")]
    public class DoctorsController : Controller
    {
        private readonly ILogger<DoctorsController> _logger;

        public DoctorsController(ILogger<DoctorsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Doctors()
        {
            _logger.LogInformation("Doctors Controller Invoked");
            return View();
        }
    }
}