using ApiCrud2.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrud2.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "Nilton Silva" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Model.Employee());
                return Ok(token);
            }
            return BadRequest("Username or Password invalid.");
        }
    }
}
