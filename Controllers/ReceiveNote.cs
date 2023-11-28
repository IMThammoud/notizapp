using Microsoft.AspNetCore.Mvc;

namespace NotizApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReceiveNote : Controller
{
    [HttpPost("ReceiveNote")]
    public IActionResult receiveNoteAsString([FromForm] string note)
    {
        // Store the note in a variable or save it to Database
        String storedNote = note;
        return Content("Your Note: "+storedNote);
    }
}