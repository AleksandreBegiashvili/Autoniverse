using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Autoniverse.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signManager)
        {
            this.userManager = userManager;
            this.signManager = signManager;
        }

        [HttpPost("action")]
        public async Task<IActionResult> Register([FromBody] RegisterDTO model)
        {
            // Will hold all the errors related to registration
            List<string> errorList = new List<string>();

            var user = new IdentityUser
            {
                Email = model.Email,
                UserName = model.Username,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, "Customer");
                // Sending confirmation email
                return Ok(new { username = user.UserName, email = user.Email, status = 1, message = "Registration Successful" });
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    errorList.Add(error.Description);
                }
            }

            return BadRequest(new JsonResult(errorList));




        }
    }
}