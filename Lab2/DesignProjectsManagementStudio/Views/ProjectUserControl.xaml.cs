using DesignProjectsManagementStudio.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DesignProjectsManagementStudio.Views
{
    public partial class ProjectUserControl : UserControl
    {
        public ProjectUserControl()
        {
            InitializeComponent();
        }

        private void ConfirmNewNameButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var project = (ProjectViewModel)ProjectsDataGrid.SelectedItem;

                if (project == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                project.Name = NewNameTextBox.Text;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }
    }
}
