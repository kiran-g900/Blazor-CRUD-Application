using System.ComponentModel.DataAnnotations;

namespace BlazorBasicsDay1_Hosted.Client.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Please enter name!")]
        public string Name { get; set; } = "";

        [Range(1,80,ErrorMessage = "Age must be between 1 and 80")]
        public int Age { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Gender is required!")]
        public string Gender { get; set; } = "";

        public bool IsConditionAgreed { get; set; } = false;

        public string Address { get; set; } = string.Empty;
    }
}
