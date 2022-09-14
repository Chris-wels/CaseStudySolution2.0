
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
    /// Interaction logic for SearchEmployeeForm.xaml
    /// </summary>
    public partial class SearchEmployeeForm : Window
    {
        public SearchEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            int eid = int.Parse(employeeIdTextBox.Text);
            Employee em =DAO.searchEmployee(eid);
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

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}
