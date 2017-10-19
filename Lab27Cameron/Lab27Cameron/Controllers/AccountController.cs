using Lab27Cameron.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lab27Cameron.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> usermanager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = usermanager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register(string returnUrl =null)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = rvm.Email, Email = rvm.Email };
                var result = await _userManager.CreateAsync(user, rvm.Password);

                if(result.Succeeded)
                {
                    //New list where claims are added
                    List<Claim> myClaims = new List<Claim>();

                    //Creates a list for claims to be added
                    Claim claim1 = new Claim(ClaimTypes.Name, rvm.StageName + " " + rvm.YearsExperience, ClaimValueTypes.String);
                    myClaims.Add(claim1);

                    //User Role Claim
                    Claim claim2 = new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String);
                    var addClaims = await _userManager.AddClaimsAsync(user, myClaims);

                    //If Claims are successful statement
                    if(addClaims.Succeeded)
                    {
                        await _signInManager.PasswordSignInAsync(rvm.Email, rvm.Password, true, lockoutOnFailure: false);
                        return RedirectToAction("Index", "Home");
                    }

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, lvm.RememberMe, lockoutOnFailure: true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        private IActionResult AccessDenied()
        {
                return View("Forbidden");
        }
    }
}
