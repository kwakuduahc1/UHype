using Microsoft.AspNetCore.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace UHype.Helper
{
    public class AuthHelper
    {
        private IHostingEnvironment _env { get; }
        private readonly IList<Claim> Claims;

        public AuthHelper(IList<Claim> claims, IHostingEnvironment environment)
        {
            _env = environment;
            Claims = claims;

        }
        public string GetKey(string id)
        {
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SxkeJZF776DgzfE!@"));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokeOptions = new JwtSecurityToken(
                issuer: _env.IsProduction() ? "https://uhype.azurewebsites.net/" : "https://localhost:44340",
                audience: _env.IsProduction() ? "https://uhype.azurewebsites.net/" : "https://localhost:44340",
                claims: Claims,
                expires: DateTime.Now.AddMonths(6),
                signingCredentials: signinCredentials
            );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
            return tokenString;
        }
    }
}
