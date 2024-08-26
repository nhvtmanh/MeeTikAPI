using MeeTikAPI.Helpers;
using System.ComponentModel.DataAnnotations;

namespace MeeTikAPI.DTOs
{
    public class RegisterDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        [Required]
        [StringLength(15, MinimumLength = 10, ErrorMessage = "Phone number must be between 10 and 15 digits long.")]
        [RegularExpression(RegexHelper.PhoneNumberPattern, ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = "";

        [Required]
        public string FullName { get; set; } = "";

        public DateOnly Birthday { get; set; }

        [StringLength(1, MinimumLength = 1)]
        public string Gender { get; set; } = "";

        public int RoleId { get; set; }

        public string AvatarURL { get; set; } = "";
    }
}
