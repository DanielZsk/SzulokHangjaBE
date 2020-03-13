using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SzulokHangjaBE.Models.Authentication;

namespace SzulokHangjaBE.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly string _authKey = "trial";
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthenticationController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User user)
        {

            if (user.AuthKey == _authKey)
            {

                var newUser = new IdentityUser { UserName = user.UserName, Email = user.Email };
                var result = await _userManager.CreateAsync(newUser, user.PassWord);

                if (result.Succeeded)
                {
                   await _signInManager.SignInAsync(newUser, isPersistent: false);
                   return Ok("Successful registration");
                }
            }

            return BadRequest();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] User user)
        {
            var result = await _signInManager.PasswordSignInAsync(user.UserName, user.PassWord, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                return Ok("Successful login");
            }
            else
            {
                return Forbid("Invalid login creds");
            }
        }
    }
}