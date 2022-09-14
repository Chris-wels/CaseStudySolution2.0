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
    /// Interaction logic for AddCustomerFormxaml.xaml
    /// </summary>
    public partial class AddCustomerFormxaml : Window
    {
        public AddCustomerFormxaml()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string telephone = telephoneTextBox.Text;
            string licenseNumber = licenseNumberTextBox.Text;
            int age = int.Parse(ageTextBox.Text);
            DateTime licenseExpiryDate = expiryDatePicker.SelectedDate.Value;

            Person p = new Person();
            p.Address = address;
            p.Name = name;
            p.Telephone = telephone;

            Customer cust = new Customer();
            cust.CustomerId = p.Id;
            cust.LicenceNumber = licenseNumber;
            cust.Age = age;
            cust.LicenceExpiryDate = licenseExpiryDate;

            cust.CustomerNavigation = p;
            try
            {
                DAO.addCustomer(cust);
                MessageBox.Show("New record added ");
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}
