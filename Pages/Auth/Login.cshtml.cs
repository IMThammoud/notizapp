using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace NotizApp.Pages.Auth;

public class Login : PageModel
{
    [BindProperty]
    public LoginModel Input { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // Assuming you have an HttpClient configured
        using (var client = new HttpClient())
        {
            var loginModel = new LoginModel
            {
                Email = Input.Email,
                Password = Input.Password
            };

            // Assuming your AuthenticationController endpoint is at /api/Authentication/login
            var response = await client.PostAsync("https://yourapi.com/api/Authentication/login", 
                new StringContent(JsonConvert.SerializeObject(loginModel), Encoding.UTF8, "application/json"));

            if (response.IsSuccessStatusCode)
            {
                // Successful login, you can handle the response here
                var token = await response.Content.ReadAsStringAsync();
                // Store the token or redirect the user to another page
            }
            else
            {
                // Login failed, handle the error (e.g., display an error message)
            }
        }

        return Page();
    }
}