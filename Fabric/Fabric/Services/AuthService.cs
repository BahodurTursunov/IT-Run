using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Fabric.Auth;
using Fabric.Contracts;
using Fabric.Infrastructure;
using Fabric.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Fabric.Services
{
    public class AuthService
    {
        private readonly FabricContext _context;
        public AuthService(FabricContext context)
        {
            _context = context;
        }

        public async Task<TokenInfo> Login(string username, string password)
        {
            var user = await _context.Customer.SingleOrDefaultAsync(x => x.Username == username && x.Password == password);

            return await GeneratedJwt(user);
        }

        public async Task<TokenInfo> RefreshToken(string refreshToken)
        {
            var user = await _context.Customer.SingleOrDefaultAsync(x => x.RefreshToken == refreshToken);

            return await GeneratedJwt(user);
        }

        async Task<TokenInfo> GeneratedJwt(Person user)
        {
            if (user is null)
                throw new ArgumentException("Invalid username or password.");

            if (user.IsBlocked)
                throw new ArgumentException("User does not have access to login.");

            var userRoles = new string[] { user.Role };
            var claims = new List<Claim> {
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.FullName),
            };

            foreach (var userRole in userRoles)
                new Claim(ClaimTypes.Role, userRole);
            
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.Issuer,
                    audience: AuthOptions.Audience,
                    claims: claims,
                    expires: DateTime.UtcNow.Add(TimeSpan.FromMinutes(AuthOptions.Lifetime)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            var accessToken = new JwtSecurityTokenHandler().WriteToken(jwt);
            var refreshToken = Guid.NewGuid().ToString();

            user.RefreshToken = refreshToken;
            _context.Update(user);
            await _context.SaveChangesAsync();
            
            return new TokenInfo { AccessToken = accessToken, RefreshToken = refreshToken };
        }
    }
}