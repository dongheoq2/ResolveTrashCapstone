using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReSolveTrash.Models
{
    public class Citizen
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(15)]
        public string UserName { get; set; }

        [Required, MaxLength(45)]
        public string Password { get; set; }

        [Required, MaxLength(62)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string PhoneNumber { get; set; }

        public int AccountStatusId { get; set; }

        [ForeignKey("AccountStatusId")]
        public AccountStatus AccountStatus { get; set; }

        public ICollection<TrashRequest> TrashRequests { get; set; }
    }
}