using System.ComponentModel.DataAnnotations;

namespace InformCPITaskServer.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? UserName{ get; set; }
    }
}
