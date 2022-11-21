using Microsoft.AspNetCore.Mvc;

namespace Clinica.Controllers
{
    public class Reports : Controller
    {
        public ActionResult Report()
        {
            return View();
        }
    }
}
