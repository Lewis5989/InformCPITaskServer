using InformCPITaskServer.Data;
using InformCPITaskServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InformCPITaskServer.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactsController : ControllerBase
    {
        
        private readonly InformCPITaskDbContext _informCPITaskDbContext;


        public ContactsController(InformCPITaskDbContext informCPITaskDbContext)
        {
            _informCPITaskDbContext = informCPITaskDbContext;
        }

        [HttpGet("{userId}")]
        async public Task<ActionResult<IEnumerable<Contact>>> GetContactsForUser(int userId)
        {
            return Ok(await _informCPITaskDbContext.Contacts.Where(contact => contact.UserId == userId).ToListAsync());
        }
    }
}