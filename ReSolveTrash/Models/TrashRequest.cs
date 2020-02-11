using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReSolveTrash.Models
{
    public class TrashRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTimeOffset RequestDate { get; set; }

        [Required]
        public DateTimeOffset FinishedDate { get; set; }

        [Required, MaxLength(100)]
        public string Location { get; set; }

        [Required, MaxLength(100)]
        public string ImageLocation { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; } 

        public int TrashTypeId { get; set; }

        public int TrashWidthId { get; set; }
        
        public int TrashSizeId { get; set; }

        public int CitizenId { get; set; }

        public int TrashRequestStatusId { get; set; }

        [ForeignKey("TrashTypeId")]
        public TrashType TrashType { get; set; }

        [ForeignKey("TrashSizeId")]
        public TrashSize TrashSize { get; set; }

        [ForeignKey("TrashWidthId")]
        public TrashWidth TrashWidth { get; set; }

        [ForeignKey("TrashRequestStatusId")]
        public TrashRequestStatus TrashRequestStatus { get; set; }

        [ForeignKey("CitizenId")]
        public Citizen Citizen { get; set; }
    }
}