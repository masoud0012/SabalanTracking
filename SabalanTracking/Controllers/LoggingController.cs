using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SabalanTracking.DTO.IdentityDTO;
using SabalanTracking.Models.IdentityEntities;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace SabalanTracking.Controllers
{
    public class LoggingController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public LoggingController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInDTO user)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.Errors = ModelState.Values.SelectMany(t => t.Errors)
                    .Select(t => t.ErrorMessage);
                return View(user);
            }
            ApplicationUser User = new ApplicationUser()
            {
                UserName = user.UserName,
                PasswordHash = user.Password
            };
            SignInResult reslt = await _signInManager.PasswordSignInAsync(User.UserName, user.Password, true, false);
            if (reslt.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("SignIn", "نام کاربری یا رمز عبور اشتباه است");
                ViewBag.Errors = ModelState.Values.SelectMany(t => t.Errors)
                   .Select(t => t.ErrorMessage);
                return View(user);
            }
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("SignIn");
        }
    }
}
