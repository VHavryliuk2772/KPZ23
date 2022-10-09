namespace Domain.Models
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; }
        public virtual ICollection<EmployeeProjectTask> EmployeeProjectTasks { get; set; }
    }
}
