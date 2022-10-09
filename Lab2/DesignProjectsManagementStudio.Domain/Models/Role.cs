namespace Domain.Models
{
    public class Role : BaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
