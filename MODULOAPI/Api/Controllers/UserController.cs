using Microsoft.AspNetCore.Mvc;
using System;


[ApiController]
[Route("[Controller]")]
public class UserController : ControllerBase
{
    [HttpGet("GetActualDateHour")]
    public IActionResult GetDateHour()
    {
        var obj = new
        {
            Date = DateTime.Now.ToLongDateString(),
            Hour = DateTime.Now.ToShortTimeString()
        };
        return Ok(obj);
    }

    [HttpGet("Presentation/{name}")]
    public IActionResult Presentation(string name)
    {
        var message = $"Hey {name}, welcome!";
        return Ok(new { message });
    }
}
