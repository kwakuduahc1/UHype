using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UHype.Helper;
using UHype.Model;
using UHype.Model.ViewModels;

namespace UHype.Controllers
{
    //[AutoValidateAntiforgeryToken]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUsers> _userManager;
        private readonly SignInManager<AppUsers> _signInManager;
        public IHostingEnvironment _env { get; }
        private readonly AppDbContext db;

        public AuthController(UserManager<AppUsers> userManager, SignInManager<AppUsers> signInManager, DbContextOptions<AppDbContext> contextOptions, IHostingEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            db = new AppDbContext(contextOptions);
            _env = environment;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody]LoginVm user)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Error = "Invalid data was submitted", Message = ModelState.Values.First(x => x.Errors.Count > 0).Errors.Select(t => t.ErrorMessage).First() });
            var _user = await _userManager.FindByNameAsync(user.UserName);
            if (_user == null)
                return Unauthorized();
            if (!await _userManager.CheckPasswordAsync(_user, user.Password))
                return Unauthorized();
            var claims = await _userManager.GetClaimsAsync(_user);
            var token = new AuthHelper(claims, _env).GetKey(user.UserName);
            return Ok(new { Token = token });
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterVm reg)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { Error = "Invalid data was submitted", Message = ModelState.Values.First(x => x.Errors.Count > 0).Errors.Select(t => t.ErrorMessage).First() });
            AppUsers user = reg.Transform();
            var result = await _userManager.CreateAsync(user, user.Password);
            if (!result.Succeeded)
                return BadRequest(new { Message = result.Errors.First().Description });
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Name, user.UserName));
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "User"));
            if (await _userManager.Users.CountAsync() < 3)
            {
                await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Researcher"));

            }
            else
            {
                await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, "Assistant"));

            }
            var _user = await _userManager.FindByIdAsync(user.Id);
            await _signInManager.SignInAsync(_user, true);
            await db.SaveChangesAsync();
            return Created("", user);
        }

        [HttpPost]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return Accepted();
        }

        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
                return await Task.FromResult<ClaimsIdentity>(null);
            var userToVerify = await _userManager.FindByNameAsync(userName);
            if (userToVerify == null) return await Task.FromResult<ClaimsIdentity>(null);
            if (await _userManager.CheckPasswordAsync(userToVerify, password))
            {
                var claim = await _userManager.GetClaimsAsync(userToVerify);
                return claim as ClaimsIdentity;
            }
            else
                return await Task.FromResult<ClaimsIdentity>(null);
        }
    }
}