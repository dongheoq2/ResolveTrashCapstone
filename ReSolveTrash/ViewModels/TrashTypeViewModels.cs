using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class TrashTypeViewModels
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class WriteTrashTypeViewModels
    {
        [Required]
        public string Name { get; set; }
    }
}