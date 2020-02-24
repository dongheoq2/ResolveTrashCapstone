using System.ComponentModel.DataAnnotations;

namespace ReSolveTrash.ViewModels
{
    public class RoleViewModels
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    public class WriteRoleViewModels
    {
        [Required]
        public string Name { get; set; }
    }
}