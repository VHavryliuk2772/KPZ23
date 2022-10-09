using System;
using System.Windows;
using AutoMapper;
using DesignProjectsManagementStudio.ViewModels;

namespace DesignProjectsManagementStudio
{
    public partial class MainWindow : Window
    {
        private readonly ContextViewModel _contextViewModel;
        private readonly IMapper _mapper;

        public MainWindow(ContextViewModel contextViewModel, IMapper mapper)
        {
            DataContext = contextViewModel;
            _mapper = mapper;
            InitializeComponent();
            SettingsUC.Mapper = mapper;
            SettingsUC.ContextViewModel = contextViewModel;
            TasksUC.Mapper = mapper;
            TasksUC.ContextViewModel = contextViewModel;
        }
    }
}
