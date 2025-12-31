using System.ComponentModel.DataAnnotations;

namespace Blazor_Auth.Model
{
    public class AuthUser
    {
        [Required]
        public int Id { get;set }
        [Required,StringLength(200)]
        public string Username { get; set; }
        [Required,StringLength(200)]
        public string Password { get; set; }
        [Required,StringLength(200)]
        public string Email { get; set; }
    }
}
