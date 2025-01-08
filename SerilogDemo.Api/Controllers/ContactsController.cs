using Microsoft.AspNetCore.Mvc;
using SerilogDemo.Application.Contacts;

namespace SerilogDemo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : Controller
{
    private readonly ILogger<ContactsController> _logger;

    public ContactsController(ILogger<ContactsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get([FromServices] IContactsService contactsService)
    {
        try
        {
            var contacts = contactsService.GetAllContacts();
            if (contacts == null || !contacts.Any())
            {
                return NoContent();
            }
            return Ok(contacts);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting all contacts.");
            return StatusCode(500, new { Message = "An error occurred while processing your request." });
        }
    }

    [HttpGet("{buId}")]
    public IActionResult GetByBusinessUnit([FromServices] IContactsService contactsService, int buId)
    {
        try
        {
            var contacts = contactsService.GetByBusinessUnit(buId);
            if (contacts == null || !contacts.Any())
            {
                return NoContent();
            }
            return Ok(contacts);
        }
        catch (ArgumentException ex)
        {
            _logger.LogError(ex, "Invalid business unit ID: {buId}", buId);
            return BadRequest(new { Message = ex.Message });
        }
    }
}
