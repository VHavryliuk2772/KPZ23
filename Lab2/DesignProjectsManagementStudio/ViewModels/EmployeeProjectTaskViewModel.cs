namespace DesignProjectsManagementStudio.ViewModels
{
    public class EmployeeProjectTaskViewModel : BaseViewModel
    {
        private int? _employeeId;
        public int? EmployeeId
        {
            get { return _employeeId; }
            set
            {
                _employeeId = value;
                OnPropertyChanged("EmployeeId");
            }
        }

        private int? _projectId;
        public int? ProjectId
        {
            get { return _projectId; }
            set
            {
                _projectId = value;
                OnPropertyChanged("ProjectId");
            }
        }

        private int? _designTaskId;
        public int? DesignTaskId
        {
            get { return _designTaskId; }
            set
            {
                _designTaskId = value;
                OnPropertyChanged("DesignTaskId");
            }
        }
    }
}
