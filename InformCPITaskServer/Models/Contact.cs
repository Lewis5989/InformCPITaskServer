using System.ComponentModel.DataAnnotations;

namespace InformCPITaskServer.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ContactName{ get; set; }
    }
}
