namespace DesignProjectsManagementStudio.ViewModels
{
    public class EmployeeRoleViewModel : BaseViewModel
    {
        private int? _employeeId;
        public int? EmployeeId {
            get { return _employeeId; }
            set
            {
                _employeeId = value;
                OnPropertyChanged("EmployeeId");
            }
        }

        private int? _roleId;
        public int? RoleId {
            get { return _roleId; }
            set
            {
                _roleId = value;
                OnPropertyChanged("RoleId");
            }
        }
    }
}
