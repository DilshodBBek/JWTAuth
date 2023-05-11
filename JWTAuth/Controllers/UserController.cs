using JWTAuth.Models;
using JWTAuth.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security;

namespace JWTAuth.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UserController : ControllerBase
{
    private readonly IJwtTokenService _jwtTokenService;

    public UserController(IJwtTokenService jwtTokenService)
    {
        _jwtTokenService = jwtTokenService;
    }

    [HttpPost]
    [Route("[action]")]
    [AllowAnonymous]
    public IActionResult Login([FromBody] UserCredentials user)
    {
        if (!_jwtTokenService.Authen(user))
        {
            return NotFound("User not found");
        }

        return Ok(_jwtTokenService.CreateToken(user));
    }

    [HttpGet]
    [Route("[action]")]
    [Authorize(Roles = "GetUser")]
    public IActionResult Getusers()
    {
        return Ok(Users.AllUsers);

    }
}