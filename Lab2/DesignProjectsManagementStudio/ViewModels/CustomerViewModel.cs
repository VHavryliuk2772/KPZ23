using Domain.Models;

namespace DesignProjectsManagementStudio.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName;  }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string _lastName;
        public string LastName {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        private string _phoneNumber;
        public string PhoneNumber {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
    }
}
