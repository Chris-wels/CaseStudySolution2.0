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
    /// Interaction logic for UpdateEmployeeForm.xaml
    /// </summary>
    public partial class UpdateEmployeeForm : Window
    {
        Employee em = null;
        Person ep;
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            int eid = int.Parse(employeeIdTextBox.Text);
            em = DAO.searchEmployee(eid);
            if (em == null)
            {
                MessageBox.Show("No record found");
            }
            else
            {
                nameTextBox.Text = em.EmployeeNavigation.Name;
                addressTextBox.Text = em.EmployeeNavigation.Address;
                telephoneTextBox.Text = em.EmployeeNavigation.Telephone;
                officeAdressTextBox.Text = em.OfficeAddress;
                phoneExtentionTextBox.Text = em.PhoneExtension;
                userNameTextBox.Text = em.Username;
                passwordTextBox.Text = em.Password;
                roleTextBox.Text = em.Role;
            }
        }

        private void UpdateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            Person ep = em.EmployeeNavigation;
            ep.Name = nameTextBox.Text;
            ep.Address = addressTextBox.Text;
            ep.Telephone = telephoneTextBox.Text;
            em.OfficeAddress = officeAdressTextBox.Text;
            em.PhoneExtension = phoneExtentionTextBox.Text;
            em.Username = userNameTextBox.Text;
            em.Password = passwordTextBox.Text;
            em.Role = roleTextBox.Text;
            DAO.updateEmployee(em, ep);
            MessageBox.Show("update employee record successfully");
            

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}
