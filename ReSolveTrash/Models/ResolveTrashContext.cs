using System.Data.Entity;

namespace ReSolveTrash.Models
{
    public class ResolveTrashContext : DbContext
    {
        public ResolveTrashContext() : base("cnnString")
        {
        }

        public DbSet<AccountStatus> AccountStatuses { get; set; }

        public DbSet<Citizen> Citizens { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<TrashRequest> TrashRequests { get; set; }

        public DbSet<TrashRequestStatus> TrashRequestStatus { get; set; }

        public DbSet<TrashSize> TrashSizes { get; set; }

        public DbSet<TrashType> TrashTypes { get; set; }

        public DbSet<TrashWidth> TrashWidths { get; set; }
    }
}