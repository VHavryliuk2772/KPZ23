namespace DesignProjectsManagementStudio.ViewModels
{
    public class RoleViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
    }
}
