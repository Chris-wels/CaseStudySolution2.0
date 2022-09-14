using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CaseStudySolution2._0.Models.DB;
using CaseStudySolution2._0.Controller;
using CaseStudySolution2._0;

namespace CaseStudySolution.Views
{
    /// <summary>
    /// Interaction logic for AddEmployeeForm.xaml
    /// </summary>
    public partial class AddEmployeeForm : Window
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string telephone = telephoneTextBox.Text;
            string officeAddress = officeAdressTextBox.Text;
            string phoneExtention = phoneExtentionTextBox.Text;
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            string role = roleTextBox.Text;

            //grabs person class
            Person p = new Person();
            p.Name = name;
            p.Address = address;
            p.Telephone = telephone;

            //grabs Employee class
            Employee em = new Employee();
            em.EmployeeId = p.Id;
            em.OfficeAddress = officeAddress;
            em.PhoneExtension = phoneExtention;
            em.Username = userName;
            em.Password = password;
            em.Role = role;

            em.EmployeeNavigation = p;
            try 
            {
                DAO.addEmployee(em);
                MessageBox.Show("Employee added successfully");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}
