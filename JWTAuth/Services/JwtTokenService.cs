using JWTAuth.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTAuth.Services
{
    public class JwtTokenService : IJwtTokenService
    {

        private readonly IConfiguration _configuration;

        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool Authen(UserCredentials user)
        {
            return Users.AllUsers.Exists(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password));
        }

        public string CreateToken(UserCredentials user)
        {
            var user1 = Users.AllUsers.FirstOrDefault(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password));
            var permission = new List<Claim>();
            foreach (var item in user1.Permission)
            {
                permission.Add(new Claim(ClaimTypes.Role, item));
            }
            Claim[] Claims = new[]
            {
                new Claim("Username", user.Username),
                new Claim("Password", user.Password)
            };

            permission.AddRange(Claims);

            JwtSecurityToken token = new(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: permission,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"])), SecurityAlgorithms.HmacSha256)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
