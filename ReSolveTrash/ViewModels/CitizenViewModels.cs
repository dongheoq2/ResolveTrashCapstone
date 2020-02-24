using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class CitizenViewModels
    {
        public string Id { get; set; }

        public string Avatar { get; set; }

        public string IdentityCode { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }
    }

    public class CreateCitizenViewModels
    {
        public string Avatar { get; set; }

        [Required, StringLength(15, MinimumLength = 6)]
        public string UserName { get; set; }

        [Required, StringLength(15, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public string IdentityCode { get; set; }

        [Required, EmailAddress, MaxLength(62)]
        public string Email { get; set; }

        [Required, StringLength(100, MinimumLength = 6)]
        public string FullName { get; set; }

        [Required, Phone, MaxLength(20)]
        public string PhoneNumber { get; set; }
    }

    public class UpdateCitizenViewModels
    {
        public string Avatar { get; set; }

        [Required]
        public string IdentityCode { get; set; }

        [Required, EmailAddress, MaxLength(62)]
        public string Email { get; set; }

        [Required, StringLength(100, MinimumLength = 6)]
        public string FullName { get; set; }

        [Required, Phone, MaxLength(20)]
        public string PhoneNumber { get; set; }
    }
}