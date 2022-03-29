using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Importør.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Importør.Pages.Login
{
    public class LoginModel : PageModel
    {

        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPost()
        //{
        //    List<User> users = _userService.Users;
        //    foreach (User user in users)
        //    {
        //        if (UserName == user.UserName)
        //        {
        //            var passwordHasher = new PasswordHasher<string>();
        //            if (passwordHasher.VerifyHashedPassword(null, user.Password, Password) == PasswordVerificationResult.Success)
        //            {
        //                //LoggedInUser = user;
        //                var claims = new List<Claim>
        //                {
        //                    new Claim(ClaimTypes.Name, UserName)
        //                };

        //                if (UserName == "admin") claims.Add(new Claim(ClaimTypes.Role, "admin"));

        //                var claimsIdentity =
        //                    new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
        //                    new ClaimsPrincipal(claimsIdentity));
        //                return RedirectToPage("/Item/GetAllItems");
        //            }
        //        }
        //    }

        //    Message = "Invalid attempt";
        //    return Page();
        //}
    }
}
