using System.ComponentModel.DataAnnotations;

namespace portalrandkowy.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Username field cannot be empty!")]
        public string Username { get; set; }
        [Required(ErrorMessage="Password field cannot be empty!")]
        [StringLength(12,MinimumLength=6, ErrorMessage="Password must be from 4 to 8 characters")]
        public string Password { get; set; }
    }
}