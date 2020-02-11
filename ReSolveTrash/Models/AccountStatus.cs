using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.Models
{
    public class AccountStatus
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(15)]
        public string Name { get; set; }

        public ICollection<Citizen> Citizens { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}