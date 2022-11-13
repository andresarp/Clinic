using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Clinica.Library
{
    public class LSpecialtycs
    {
        public List<SelectListItem> getSpecialty(RoleManager<IdentityRole> roleManager)
        { 
        List<SelectListItem> _selectLists = new List<SelectListItem>();
            var specialtycs = roleManager.Roles.ToList();
            specialtycs.ForEach(item => {
                _selectLists.Add(new SelectListItem {
                
                    Value = item.Id,
                    Text = item.Name,
                });
            });
            return _selectLists;
        }
    }
}
