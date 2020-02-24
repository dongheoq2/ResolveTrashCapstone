using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class EmployeeViewModels
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Avatar { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string IdentityCode { get; set; }

        public bool IsActive { get; set; }
    }

    public class CreateEmployeeViewModels
    {
        [Required, StringLength(255, MinimumLength = 6)]
        public string Username { get; set; }

        [Required, StringLength(255, MinimumLength = 6)]
        public string Password { get; set; }

        public string Avatar { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; }

        [Required, StringLength(255, MinimumLength = 6)]
        public string FullName { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(255)]
        public string IdentityCode { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }

    public class UpdateEmployeeViewModels
    {
        [Required, StringLength(255, MinimumLength = 6)]
        public string Username { get; set; }

        public string Avatar { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; }

        [Required, StringLength(255, MinimumLength = 6)]
        public string FullName { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(255)]
        public string IdentityCode { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}