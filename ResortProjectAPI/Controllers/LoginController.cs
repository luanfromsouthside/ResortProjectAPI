using Microsoft.AspNetCore.Mvc;
using System;
using ResortProjectAPI.ModelRequest;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace ResortProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("User")]
        [AllowAnonymous]
        public IActionResult Login(LoginModel model)
        {
            IActionResult response = Unauthorized();
            if (model.Username != "admin" && model.Username != "user") return BadRequest("Does not exist");
            if (model.Password != "1234567") return BadRequest("Invalid password");
            var tokenStr = GenerateJSONWebToken(model,"admin");
            response = Ok(new { token = tokenStr });
            return response;
        }
        //Method NonAction
        [NonAction]
        private string GenerateJSONWebToken(LoginModel model, string role)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:JWT_Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, model.Username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role,role)
            };
            var token = new JwtSecurityToken(
                issuer: _config["JWT:Issuer"],
                audience: _config["JWT:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
