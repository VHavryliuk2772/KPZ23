using Domain.Models;
using System;
using Domain.Enums;

namespace DesignProjectsManagementStudio.ViewModels
{
    public class ProjectViewModel : BaseViewModel
    {
        public Project Project { get; set; }

        private ProjectType? _type;
        public ProjectType? Type
        {
            get { return _type; }
            set
            {
                _type = value;

                if (Project != null)
                {
                    Project.Type = value;
                }

                OnPropertyChanged("Type");
            }
        }

        private int? _customerId;
        public int? CustomerId 
        {
            get { return _customerId; } 
            set 
            {
                _customerId = value;

                if (Project != null)
                {
                    Project.CustomerId  = value;
                }

                OnPropertyChanged("CustomerId");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                
                if(Project != null)
                {
                    Project.Name = value;
                }

                OnPropertyChanged("Name");
            }
        }

        private DateOnly? _startDate;
        public DateOnly? StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged("StartDate");
            }
        }

        private DateOnly? _endDate;
        public DateOnly? EndDate 
        {
            get { return _endDate; }
            set
            {
                _endDate = value;

                if(Project != null)
                {
                    Project.EndDate = value;
                }

                OnPropertyChanged("EndDate");
            }
        }
    }
}
