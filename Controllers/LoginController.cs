
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MOCKAPP.Server.Model;
using MOCKAPP.Server.Service;
using MOCKAPP.Server.User;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace MOCKAPP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly Iauthservice _authService;
        private readonly ILogger<LoginController> _logger;

        public LoginController(Iauthservice authService, ILogger<LoginController> logger)
        {
            _authService = authService;
            _logger = logger;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(Login model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest("Invalid payload");
                var (status, response) = await _authService.Login(model);
                if (status == 0)
                    return BadRequest(response);              
                return Ok(new { response });               
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login([FromBody] Login model)
        //{
        //    var user = await _userManager.FindByNameAsync(model.UserName);
        //    if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
        //    {
        //        var userRoles = await _userManager.GetRolesAsync(user);

        //        var authClaims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name, user.UserName),
        //            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //        };

        //        foreach (var userRole in userRoles)
        //        {
        //            authClaims.Add(new Claim(ClaimTypes.Role, userRole));
        //        }

        //        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

        //        var token = new JwtSecurityToken(
        //            issuer: _configuration["JWT:ValidIssuer"],
        //            audience: _configuration["JWT:ValidAudience"],
        //            expires: DateTime.Now.AddHours(3),
        //            claims: authClaims,
        //            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //            );

        //        return Ok(new
        //        {
        //            token = new JwtSecurityTokenHandler().WriteToken(token),
        //            expiration = token.ValidTo,
        //            status = "Success"
        //        }); ;
        //    }
        //    return Unauthorized();

        //}

        //    private readonly UserManager<IdentityUser> _userManager;

        //    private readonly IConfiguration _configuration;

        //    [HttpPost]
        //    [Route("login")]
        //    public async Task<IActionResult> Login([FromBody] Login model)

        //    {
        //        var user = await _userManager.FindByNameAsync(model.UserName);
        //        if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
        //        {
        //            var userRoles = await _userManager.GetRolesAsync(user);
        //            var authClaims = new List<Claim>
        //            {
        //                new Claim(ClaimTypes.Name, user.UserName),
        //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //            };
        //            foreach (var userRole in userRoles)
        //            {
        //                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
        //            }
        //            var token = GetToken(authClaims);
        //            return Ok(new
        //            {
        //                token = new JwtSecurityTokenHandler().WriteToken(token),
        //                expiration = token.ValidTo
        //            });
        //        }
        //        return Unauthorized();
        //    }

        //    private JwtSecurityToken GetToken(List<Claim> authClaims)
        //    {
        //        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));
        //        var token = new JwtSecurityToken(
        //            issuer: _configuration["JWT:ValidIssuer"],
        //            audience: _configuration["JWT:ValidAudience"],
        //            expires: DateTime.Now.AddHours(3),
        //            claims: authClaims,
        //            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //            );
        //        return token;
        //    }
        //}


    }
}
