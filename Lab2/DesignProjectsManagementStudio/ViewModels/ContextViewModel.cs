using System.Collections.ObjectModel;
using System.Windows.Input;
using AutoMapper;
using Persistance;
using System;
using System.Linq;
using System.Collections.Specialized;
using Domain.Models;
using Microsoft.Data.SqlClient;

namespace DesignProjectsManagementStudio.ViewModels
{
    public class ContextViewModel : BaseViewModel
    {
        private readonly IMapper _mapper;
        private readonly ApplicationContext _context;
        
        public ContextViewModel(IMapper mapper, ApplicationContext context)
        {
            _mapper = mapper;
            _context = context;

            Customers = _mapper.Map<ObservableCollection<CustomerViewModel>>(_context.Customers);
            Employees = _mapper.Map<ObservableCollection<EmployeeViewModel>>(_context.Employees);
            EmployeeProjectTasks = _mapper.Map<ObservableCollection<EmployeeProjectTaskViewModel>>(_context.EmployeeProjectTasks);
            EmployeeRoles = _mapper.Map<ObservableCollection<EmployeeRoleViewModel>>(_context.EmployeeRoles);
            Roles = _mapper.Map<ObservableCollection<RoleViewModel>>(_context.Roles);
            Projects = _mapper.Map<ObservableCollection<ProjectViewModel>>(_context.Projects);
            //DesignTasks = _mapper.Map<ObservableCollection<DesignTaskViewModel>>(_context.DesignTasks);
            DesignTasks = SelectUsingADONET();
            SetControlVisibility = new Command(ControlVisibility);
            SetCurrentDateCommand = new Command(SetCurrentDate);
            SelectCurrentEmployeeProjectsCommand = new Command(SelectCurrentEmployeeProjects);
            Customers.CollectionChanged += Customers_CollectionChanged;
        }

        private ObservableCollection<ProjectViewModel> _selectedEmployeeProjects;
        public ObservableCollection<ProjectViewModel> SelectedEmployeeProjects 
        {
            get { return _selectedEmployeeProjects; }
            set 
            {
                _selectedEmployeeProjects = value;
                OnPropertyChanged("SelectedEmployeeProjects");
            }
        }

        private EmployeeViewModel _selectedEmployee;
        public EmployeeViewModel SelectedEmployee 
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                SelectedEmployeeProjects = _mapper.Map<ObservableCollection<ProjectViewModel>>(_context.EmployeeProjectTasks.Where(ept => ept.EmployeeId == value.Id).Select(ept => ept.Project));
                OnPropertyChanged("SelectedEmployee");
            }
        } 

        public ICommand SelectCurrentEmployeeProjectsCommand { get; set; }
        public void SelectCurrentEmployeeProjects(object args)
        {
            var employee = (EmployeeViewModel)args;
            SelectedEmployee = employee;
        }

        public ICommand SetCurrentDateCommand { get; set; }
        public void SetCurrentDate(object args)
        {
            var dateTime = DateTime.Now;
            SelectedProject.EndDate = new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }

        private ProjectViewModel _selectedProject;
        public ProjectViewModel SelectedProject
        {
            get { return _selectedProject; }
            set
            {
                _selectedProject = value;
                OnPropertyChanged("SelectedProject");
            }
        }

        public ICommand SetControlVisibility { get; set; }
        public void ControlVisibility(object args)
        {
            VisibleTab = args.ToString();
        }

        private string _visibleTab = "Projects";
        public string VisibleTab 
        {
            get { return _visibleTab; }
            set
            {
                _visibleTab = value;
                OnPropertyChanged("VisibleTab");
            }
        }

        private ObservableCollection<CustomerViewModel> _customers;
        public ObservableCollection<CustomerViewModel> Customers 
        {
            get { return _customers; }
            set
            {
                _customers = value;
                OnPropertyChanged("Customers");
            }
        }

        private ObservableCollection<EmployeeViewModel> _employees;
        public ObservableCollection<EmployeeViewModel> Employees 
        {
            get { return _employees; }
            set
            {
                _employees = value;
                OnPropertyChanged("Employees");
            }
        }

        private ObservableCollection<EmployeeProjectTaskViewModel> _employeeProjectTasks;
        public ObservableCollection<EmployeeProjectTaskViewModel> EmployeeProjectTasks 
        {
            get { return _employeeProjectTasks; }
            set
            {
                _employeeProjectTasks = value;
                OnPropertyChanged("EmployeeProjectTasks");
            }
        }

        private ObservableCollection<EmployeeRoleViewModel> _employeeRoles;
        public ObservableCollection<EmployeeRoleViewModel> EmployeeRoles
        {
            get { return _employeeRoles; }
            set
            {
                _employeeRoles = value;
                OnPropertyChanged("EmployeeRoles");
            }
        }

        private ObservableCollection<RoleViewModel> _roles;
        public ObservableCollection<RoleViewModel> Roles
        {
            get { return _roles; }
            set
            {
                _roles = value;
                OnPropertyChanged("Roles");
            }
        }

        private ObservableCollection<DesignTaskViewModel> _designTasks;
        public ObservableCollection<DesignTaskViewModel> DesignTasks
        {
            get { return _designTasks; }
            set
            {
                _designTasks = value;
                OnPropertyChanged("DesignTasks");
            }
        }

        private ObservableCollection<ProjectViewModel> _projects;
        public ObservableCollection<ProjectViewModel> Projects 
        {
            get { return _projects; }
            set
            {
                _projects = value;
                OnPropertyChanged("Projects");
            }
        }

        private void Customers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:               
                    foreach (var item in e.NewItems)
                    {
                        _context.Customers.Add(_mapper.Map<Customer>(item as CustomerViewModel));
                    }                         
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (var item in e.OldItems)
                    {
                        _context.Customers.Remove(_context.Customers.FirstOrDefault(c => c.Id == (item as CustomerViewModel).Id));
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;

            }
        }

        private ObservableCollection<DesignTaskViewModel> SelectUsingADONET()
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=KPZ2;Trusted_Connection=True;";
            var sql = "SELECT * FROM dbo.DesignTasks;";
            var collection = new ObservableCollection<DesignTaskViewModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sql, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        collection.Add(new DesignTaskViewModel
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Description = (string)reader["Description"],
                        });
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    return collection;
                }
            }
            return collection;
        }
    }
}
