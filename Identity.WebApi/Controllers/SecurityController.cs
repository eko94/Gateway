using Identity.Application.Services;
using Identity.WebApi.Infrastructure;
using Identity.WebApi.Model;
using Identity.WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nur.Store2025.Access.Identity.Permissions;

namespace Identity.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class SecurityController(ISecurityService securityService) : CustomController
{

    [AllowAnonymous]
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        var result = await securityService.Login(model.Username, model.Password);

        return BuildResult(result);
    }

    //register user
    [AllowAnonymous]
    [HttpPost]
    [Route("register-user")]    
    public async Task<IActionResult> RegisterUser([FromBody] RegisterUserModel model)
    {
        try
        {
            var result = await securityService.RegisterUser(model.Email, model.Password, model.FirstName, model.LastName);
            return BuildResult(result);
        }        
        catch(Exception ex)
        {
            return BadRequest(new 
            {
                ErrorMessage = ex.Message,
                ErrorCode = "RegistrationError",
                Stack = ex.StackTrace,
                inner = ex.InnerException?.Message
            });
        }
    }
}
