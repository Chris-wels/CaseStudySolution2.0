
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
    /// Interaction logic for UpdateCustomerForm.xaml
    /// </summary>
    public partial class UpdateCustomerForm : Window
    {
        //intialize two variables as null... I think they can both be null I believe they already are null even tho one isnt specifically = null
        Customer cust = null;
        Person cp;
        public UpdateCustomerForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //Searching employee using the Id
            int cid = int.Parse(CustomerIdTextBox.Text);
            // Uses the DAO controller method to search for the customer by ID and retrieve all details
            cust = DAO.searchCustomer(cid);
            if (cust == null)//if no records are found show message
            {
                MessageBox.Show("sorry no customer found");
            }
            else
            {
                //if details are found assign each textbox the corresponding values
                nameTextBox.Text = cust.CustomerNavigation.Name;
                addressTextBox.Text = cust.CustomerNavigation.Address;
                telephoneTextBox.Text = cust.CustomerNavigation.Telephone;
                ageTextBox.Text = cust.Age.ToString();
                licenseNumberTextBox.Text = cust.LicenceNumber;
                expiryDatePicker.SelectedDate = cust.LicenceExpiryDate;

            }
        }

        private void UpdateCustomerButton_Click(object sender, RoutedEventArgs e)
        {

            //Define a new instance for the Person Object give it a name(cp) and a new value "cust.CustomerNavigation"
            //cust varibale name for the Customer Class was initially null but was then given the DAO Class Controller method searchCustomer(cid)
            //Customer Navigation retrives data from the Person class as the Person and Customer Class share data
            //cp is the new variable name specific for the values that will be entered into the Person Class
            
            Person cp = cust.CustomerNavigation;
            cp.Name = nameTextBox.Text;
            cp.Address = addressTextBox.Text;
            cp.Telephone = telephoneTextBox.Text;
            cust.Age = int.Parse(ageTextBox.Text);
            cust.LicenceNumber = licenseNumberTextBox.Text;
            cust.LicenceExpiryDate = expiryDatePicker.SelectedDate.Value;
            //The DAO Class method UpdateCustomer has two individual properties that with each manipulating the data in their respective classes
            //cust manipulates the data in the Customer Class ||   cp manipulates the data in the Person Class
            DAO.updateCustomer(cust, cp);
            MessageBox.Show("Updated Successfully");

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
    
}
