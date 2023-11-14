using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SabalanTracking.DTO.IdentityDTO;
using SabalanTracking.Models.IdentityEntities;

namespace SabalanTracking.Controllers
{
    [Authorize(Roles = "Admin")]
//    [Route("[controller]/[action]")]
    public class RolesController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public RolesController(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            List<ApplicationRole> roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleDTO role)
        {
            if (ModelState.IsValid)
            {
                if (_roleManager.RoleExistsAsync(role.Name).Result)
                {
                    return View(role);
                }
                var result = await _roleManager.CreateAsync(role.ToRole());
                if (result.Succeeded)
                {
                    // Role created successfully, redirect to a different action or view
                    return RedirectToAction("Index");
                }

                // If there are errors, add them to ModelState
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If ModelState is not valid or role creation fails, return to the same view
            return View(role);
        }


        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var role=await _roleManager.FindByIdAsync(id.ToString());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationRole role)
        {
            var model = await _roleManager.DeleteAsync(role);
            if (model.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
