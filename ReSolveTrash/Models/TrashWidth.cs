using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.Models
{
    public class TrashWidth
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(15)]
        public string Name { get; set; }

        public ICollection<TrashRequest> TrashRequests { get; set; }
    }
}