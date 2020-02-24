using System;
using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class TrashRequestViewModels
    {
        public int Id { get; set; }

        public DateTimeOffset RequestDate { get; set; }

        public DateTimeOffset FinishedDate { get; set; }

        public string Location { get; set; }

        public string ImageLocation { get; set; }

        public string Description { get; set; } 

        public string TrashType { get; set; }
        
        public string TrashSize { get; set; }

        public string TrashWidth { get; set; }

        public string TrashRequestStatus { get; set; }

        public string Citizen { get; set; }
    }

    public class WriteTrashRequestViewModels
    {
        [Required]
        public DateTimeOffset FinishedDate { get; set; }

        [Required, MaxLength(255)]
        public string Location { get; set; }

        public string ImageLocation { get; set; }

        public string Description { get; set; }

        [Required]
        public int TrashTypeId { get; set; }

        [Required]
        public int TrashSizeId { get; set; }

        [Required]
        public int TrashWidthId { get; set; }

        [Required]
        public int TrashRequestStatusId { get; set; }

        [Required]
        public int CitizenId { get; set; }
    }
}