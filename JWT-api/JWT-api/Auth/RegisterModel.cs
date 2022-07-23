using System.ComponentModel.DataAnnotations;

namespace JWT_api.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is requerided")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is requerided")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is requerided")]
        public string? Password { get; set; }
    }
}
