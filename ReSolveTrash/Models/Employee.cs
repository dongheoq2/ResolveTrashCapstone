namespace ReSolveTrash.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string EmployeeId { get; set; }

        public int RoleId { get; set; }

        public int AccountStatusId { get; set; }

        public Role Role { get; set; }
        
        public AccountStatus AccountStatus { get; set; }
    }
}