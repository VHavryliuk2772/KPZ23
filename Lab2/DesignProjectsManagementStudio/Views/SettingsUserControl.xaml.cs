using Domain;
using System.Windows;
using System.Windows.Controls;
using DesignProjectsManagementStudio.ViewModels;
using AutoMapper;
using System;

namespace DesignProjectsManagementStudio.Views
{
    public partial class SettingsUserControl : UserControl
    {
        public ContextViewModel ContextViewModel;
        public IMapper Mapper;
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void InsertEFButton_Click(object sender, RoutedEventArgs e)
        {
            var newViewModel = new CustomerViewModel()
            {
                Email = EmailEFTextBox.Text,
                FirstName = FirstNameEFTextBox.Text,
                LastName = LastNameEFTextBox.Text,
                PhoneNumber = PhoneEFTextBox.Text,
            };
            ContextViewModel.Customers.Add(newViewModel);
        }

        private void UpdateEFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldCustomer = (CustomerViewModel)CustomersDataGrid.SelectedItem;

                if (oldCustomer == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                var newCustomer = new CustomerViewModel
                {
                    Id = oldCustomer.Id,
                    FirstName = FirstNameEFTextBox.Text,
                    LastName = LastNameEFTextBox.Text,
                    PhoneNumber = PhoneEFTextBox.Text,
                    Email = EmailEFTextBox.Text
                };
                ContextViewModel.Customers.Remove(oldCustomer);
                ContextViewModel.Customers.Add(newCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }

        private void DeleteEFButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldCustomer = (CustomerViewModel)CustomersDataGrid.SelectedItem;

                if (oldCustomer == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                ContextViewModel.Customers.Remove(oldCustomer);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }
    }
}
