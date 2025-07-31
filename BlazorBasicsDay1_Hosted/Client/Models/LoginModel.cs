using System.ComponentModel.DataAnnotations;

namespace BlazorBasicsDay1_Hosted.Client.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter valid password")]
        public string Password { get; set; }

        public string Role { get; set; } = "User";
    }
}
