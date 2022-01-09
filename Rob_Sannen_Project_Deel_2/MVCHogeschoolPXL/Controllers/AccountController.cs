using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCHogeschoolPXL.Data;
using MVCHogeschoolPXL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCHogeschoolPXL.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private SignInManager<IdentityUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;
        private ApplicationDbContext _context;

        public AccountController(UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager, 
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _context = context;
        }


        #region Register

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.RoleId = new SelectList(_context.Roles, "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterViewModel user)
        {
            if (ModelState.IsValid)
            {
                if (await _userManager.FindByEmailAsync(user.Email) != null)
                {
                    ModelState.AddModelError("", "Email adres is al geregistreerd!");
                    return View(user);
                }
                var identityUser = new IdentityUser { UserName = user.Email, Email = user.Email };
                var result = await _userManager.CreateAsync(identityUser, user.Password);
                if (result.Succeeded)
                {
                    var role = await _roleManager.FindByIdAsync(user.RoleId);
                    if (role != null)
                    {
                        await _userManager.AddToRoleAsync(identityUser, role.Name);
                        return View("RegistrationCompleted", identityUser);
                    }
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(user);
                }
            }
            return View(user);
        }

        #endregion

        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var identityUser = await _userManager.FindByEmailAsync(user.Email);
                if (identityUser != null)
                {
                    var userName = identityUser.UserName;
                    var result = await _signInManager.PasswordSignInAsync(userName, user.Password, false, false);
                    if (result.Succeeded)
                    {
                        return View("LoginCompleted", identityUser);
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid login attempt");
                    }
                }
                ModelState.AddModelError("", "Invalid login attempt");
            }
            return View(user);
        }

        #endregion

        #region Logout

        public async Task<IActionResult> LogoutAsync()
        {
            await _signInManager.SignOutAsync();
            var user = await _userManager.GetUserAsync(HttpContext.User);
            return View("LogoutCompleted");
        }

        #endregion

        #region Access denied

        public IActionResult AccessDenied()
        {
            return View();
        }

        #endregion
    }
}
