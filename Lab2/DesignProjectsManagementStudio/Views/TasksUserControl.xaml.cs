using AutoMapper;
using DesignProjectsManagementStudio.ViewModels;
using Domain.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DesignProjectsManagementStudio.Views
{
    public partial class TasksUserControl : UserControl
    {
        public ContextViewModel ContextViewModel;
        public IMapper Mapper;

        public TasksUserControl()
        {
            InitializeComponent();
        }

        private void InsertADOButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newViewModel = new DesignTask()
                {
                    Name = NameADOTextBox.Text,
                    Description = DescriptionTextBox.Text,
                };

                var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=KPZ2;Trusted_Connection=True;";
                var sql = $"INSERT INTO dbo.DesignTasks (Name, Description) VALUES('{newViewModel.Name}','{newViewModel.Description}');";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                   
                    var sqlSelect = "SELECT TOP 1 * FROM dbo.DesignTasks order by Id desc;";

                    SqlCommand commandSelect = new SqlCommand(sqlSelect, connection);
                    SqlDataReader reader = commandSelect.ExecuteReader();
                    reader.Read();
                    var newItem = new DesignTaskViewModel
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        Description = (string)reader["Description"],
                    };

                    reader.Close();                 
                    ContextViewModel.DesignTasks.Add(newItem);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!","Alert");
                return;
            }          
        }

        private void UpdateADOButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldTask= (DesignTaskViewModel)TasksDataGrid.SelectedItem;

                if (oldTask == null)
                {
                    MessageBox.Show("Please choose task you want to change!", "Alert");
                    return;
                }

                var newTask = new DesignTask
                {
                    Name = NameADOTextBox.Text,
                    Description = DescriptionTextBox.Text,
                };

                var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=KPZ2;Trusted_Connection=True;";
                var sql = $"UPDATE dbo.DesignTasks SET " +
                    $"Name = '{newTask.Name}',Description='{newTask.Description}'  WHERE Id = {oldTask.Id};";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    oldTask.Name = newTask.Name;
                    oldTask.Description = newTask.Description;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }

        private void DeleteADOButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var oldTask = (DesignTaskViewModel)TasksDataGrid.SelectedItem;

                if (oldTask == null)
                {
                    MessageBox.Show("Please choose project you want to change name!", "Alert");
                    return;
                }

                var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=KPZ2;Trusted_Connection=True;";
                var sql = $"DELETE FROM dbo.DesignTasks WHERE Id = {oldTask.Id};";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    ContextViewModel.DesignTasks.Remove(oldTask);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Alert");
            }
        }
    }
}
