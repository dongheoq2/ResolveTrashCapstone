using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class TrashSizeViewModels
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class WriteTrashSizeViewModels
    {
        [Required]
        public string Name { get; set; }
    }
}