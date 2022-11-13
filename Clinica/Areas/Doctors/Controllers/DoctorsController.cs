using Microsoft.AspNetCore.Mvc;

namespace Clinica.Areas.Doctors.Controllers
{
    [Area("Doctors")]
    public class DoctorsController : Controller
    {
        
        public IActionResult Doctors()
        {
            return View();
        }
    }
}
