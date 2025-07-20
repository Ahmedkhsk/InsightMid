using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InsightMid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<ApplicationUser> userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(registerModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (model.Password != model.confirmPassword)
            {
                return BadRequest("Passwords do not match.");
            }
            string email = model.Email;
            var existingUser = await userManager.FindByEmailAsync(email);
            if (existingUser != null)
            {
                return BadRequest("User with this email already exists.");
            }
            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {

                return Ok("User registered successfully.");
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(loginModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
            {
                return BadRequest("Invalid email or password.");
            }
            return Ok("Login successful.");
        }
    }
}
