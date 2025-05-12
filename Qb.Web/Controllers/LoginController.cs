using Microsoft.AspNetCore.Mvc;
using Qb.Application.Interfaces;
using Qb.Domain.Entities;
using Qb.Infrastructure.CrossCutting.Services;

namespace Qb.Web.Controllers;

public class LoginController( ILogger<CategoryController> logger, IUserService userService): Controller
{
    [Route("/login")]
    public IActionResult Index()
    {
        return View("~/Views/Login/Index.cshtml");
    }
    
    [HttpPost]
    public async Task<IActionResult> Auth([FromForm] string email, [FromForm] string password)
    {   
        
        User? user = await userService.GetUserByEmail(email);
        if (user == null ||  !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return BadRequest(new { success = false, message = "Invalid credentials" });     
        }
        
        UserSession.CreateSession( HttpContext, user);
        
        return Ok(new { success = true });
    }
}