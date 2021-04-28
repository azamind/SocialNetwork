using System.ComponentModel.DataAnnotations;

namespace SocialNetworkProject.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
