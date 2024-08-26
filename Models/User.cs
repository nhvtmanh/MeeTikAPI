using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.DataAnnotations;
using MeeTikAPI.Helpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeeTikAPI.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string PasswordHash { get; set; } = "";

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
