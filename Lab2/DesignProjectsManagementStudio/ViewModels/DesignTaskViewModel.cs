namespace DesignProjectsManagementStudio.ViewModels
{
    public class DesignTaskViewModel : BaseViewModel
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

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
    }
}
