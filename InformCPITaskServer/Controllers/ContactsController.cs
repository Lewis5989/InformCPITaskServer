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

        [HttpPost]
        async public Task AddNewContact([FromBody]Contact contact)
        {
            var newContact = new Contact
            {
                UserId = contact.UserId,
                ContactName = contact.ContactName,
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber
            };
            await _informCPITaskDbContext.Contacts.AddAsync(newContact);
            Ok(_informCPITaskDbContext.SaveChanges());
        }

        [HttpPut]
        async public Task UpdateContact([FromBody] Contact contact)
        {
            _informCPITaskDbContext.Contacts.Update(contact);
            Ok(await _informCPITaskDbContext.SaveChangesAsync());
        }


    }
}