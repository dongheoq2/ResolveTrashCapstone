using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class TrashRequestStatusViewModels
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class WriteTrashRequestStatusViewModels
    {
        [Required]
        public string Name { get; set; }
    }
}