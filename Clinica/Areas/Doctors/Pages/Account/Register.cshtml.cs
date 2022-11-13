using Clinica.Library;
using Clinica.Areas.Doctors.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Clinica.Data;

namespace Clinica.Areas.Doctors.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private LSpecialtycs _specialty;
        private static InputModel _dataInput;
        private Data.ApplicationDbContext _context;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _specialty = new LSpecialtycs();
            _context = context;

        }

        public void OnGet()
        {
            if (_dataInput != null)
            {
                Input = _dataInput;
                Input.SpecialtyList = _specialty.getSpecialty(_roleManager);
                Input.AvatarImage = null;
            }
            else
            {
                Input = new InputModel
                {
                    SpecialtyList = _specialty.getSpecialty(_roleManager)
                };
            }
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }

            [TempData]
            public string ErrorMessage { get; set; }

            public List<SelectListItem> SpecialtyList { get; set; }
        }

        public async Task<IActionResult> OnPost()
        { 
            if(await SaveAsync())
            {
                return Redirect("/Doctors/Doctors?area=Doctors");
            }
            else
            {
                return Redirect("Doctors/Register");
            }
        
        }
        private async Task<bool> SaveAsync()
        {
            _dataInput = Input;
            var valor = false;
            if (ModelState.IsValid)
            {
                var doctorList = _userManager.Users.Where(u=> u.Id.Equals(Input.id)).ToList();
                if (doctorList.Count.Equals(0))
                {
                    var strategy = _context.Database.CreateExecutionStrategy();
                }
            }
            else
            {
                _dataInput.ErrorMessage = "Seleccione una especialidad";
            }

            return valor;
        }
    }

}
