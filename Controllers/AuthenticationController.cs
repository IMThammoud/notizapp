namespace NotizApp;

using Microsoft.AspNetCore.Mvc;
using NotizApp.Models;
using System;
using NotizApp.Services;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthenticationController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
        var user = AuthenticateUser(model.Email, model.Password);

        if (user != null)
        {
            var token = _authService.GenerateJwtToken(user);
            return Ok(new { token });
        }

        return Unauthorized();
    }

    private User AuthenticateUser(string email, string password)
    {
        // Implement your user authentication logic here,
        // comparing the hashed password with the stored hash.
        // Return the User object if authentication is successful.
        // Placeholder for demonstration; replace with actual user authentication.
        throw new NotImplementedException();
    }
}

public class LoginModel
{
    public string Email { get; set; }
    public string Password { get; set; }
}