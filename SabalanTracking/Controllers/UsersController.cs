using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SabalanTracking.DTO.IdentityDTO;
using SabalanTracking.Models.IdentityEntities;

namespace SabalanTracking.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UsersController : Controller
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public UsersController(UserManager<ApplicationUser> userManager
            , RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var roles = users.Select(t => _userManager.GetRolesAsync(t).Result).ToList();
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterDTO userDTO)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(t => t.Errors).Select(
                    t => t.ErrorMessage);
                return View(userDTO);
            }
            ApplicationUser existingUser = await _userManager.FindByEmailAsync(userDTO.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "Email address is already registered.");
                return View(userDTO);
            }
            ApplicationUser User = userDTO.ToApplicationUser();
            IdentityResult result = await _userManager.CreateAsync(User, userDTO.Password);
            if (result.Succeeded)
            {
                if (!await _userManager.IsInRoleAsync(User, "User"))
                {
                    // If not, add the userDTO to the role
                    await _userManager.AddToRoleAsync(User, "User");
                }

                return RedirectToAction("Index");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("Create", error.Description);
                }

                ViewBag.Errors = ModelState.Values.SelectMany(t => t.Errors).Select(
                    t => t.ErrorMessage);
                return View(userDTO);
            }
        }

        [HttpGet]
        public async Task<IActionResult> EditRole(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null)
            {
                return NotFound();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            var allRoles = _roleManager.Roles.ToList();

            var viewModel = new UserRoleViewModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                Roles = userRoles.ToList(),
                AvailableRoles = allRoles.Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name,
                    Selected = userRoles.Contains(r.Name)
                }).ToList()
            };
            return View(viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> EditRole(UserRoleViewModel viewModel, string[] newRoles)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(viewModel.UserId.ToString());

                if (user == null)
                {
                    return NotFound();
                }
                var currentRoles = await _userManager.GetRolesAsync(user);
                var rolesToRemove = currentRoles.Except(viewModel.Roles);
                var rolesToAdd = viewModel.Roles.Except(currentRoles);
                await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
                await _userManager.AddToRolesAsync(user, rolesToAdd);
                return RedirectToAction("Index"); // Redirect to your user list page
            }

            // If the model state is not valid, redisplay the form
            viewModel.AvailableRoles = _roleManager.Roles
                .Select(r => new SelectListItem
                {
                    Text = r.Name,
                    Value = r.Name,
                    Selected = viewModel.Roles.Contains(r.Name)
                }).ToList();

            return View(viewModel);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationUser user)
        {
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
