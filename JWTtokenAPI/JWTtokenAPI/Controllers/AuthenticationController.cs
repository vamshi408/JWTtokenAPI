using JWTtokenAPI.Interfaces;
using JWTtokenAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTtokenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IJwtService _jwtService;
        public AuthenticationController(IJwtService jwtService)
        {
            this._jwtService = jwtService;
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(UserCredentialsModel userCredentials)
        {
            var token = _jwtService.Authentication(userCredentials.username, userCredentials.password);
            return Ok(token);
        }
    }
}
