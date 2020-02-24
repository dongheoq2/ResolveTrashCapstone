using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class TrashWidthViewModels
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class WriteTrashWidthViewModels
    {
        [Required]
        public string Name { get; set; }
    }
}