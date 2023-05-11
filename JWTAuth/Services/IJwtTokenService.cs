using JWTAuth.Models;

namespace JWTAuth.Services
{
    public interface IJwtTokenService
    {
        public bool Authen(UserCredentials user);

        public string CreateToken(UserCredentials user);
    }
}
