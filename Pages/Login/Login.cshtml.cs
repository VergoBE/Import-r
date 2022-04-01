using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Importør.Services;
using Importør.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace Importør.Pages.Login
{
    public class LoginModel : PageModel
    {
        private UserService userService;

        public LoginModel(UserService userService)
        {
            this.userService = userService;
        }
        [BindProperty] public string UserName { get; set; }
        [BindProperty, DataType(DataType.Password)] public string Password { get; set; }
        public string Message { get; set; }

       public async Task<IActionResult> OnPost()
        {
            List<User> userList = new List<User>();
            foreach(User u in userList)
            {
                if (UserName == u.UserName)
                {
                    var passwordHasher = new PasswordHasher<string>();
                    if(passwordHasher.VerifyHashedPassword(null,u.Password,Password) == PasswordVerificationResult.Success)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name,UserName)
                        };
                        if (UserName !="admin") claims.Add(new Claim(ClaimTypes.Role, "Customer"));
                        var claimsIdentity =
                            new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity));
                        return RedirectToPage("/Car/GetAllCars");
                    }
                }
            }
            return RedirectToPage("/Car/GetAllCars");
        }
    }
}
