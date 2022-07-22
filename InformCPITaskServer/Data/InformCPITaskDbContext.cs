using InformCPITaskServer.Models;
using Microsoft.EntityFrameworkCore;

namespace InformCPITaskServer.Data
{
    public class InformCPITaskDbContext:DbContext
    {
        public InformCPITaskDbContext(DbContextOptions<InformCPITaskDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { set; get; }
        public DbSet<User> Users { get; set; }
    }
}
