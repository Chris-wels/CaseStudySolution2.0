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
    /// Interaction logic for SearchCustomerForm.xaml
    /// </summary>
    public partial class SearchCustomerForm : Window
    {
        public SearchCustomerForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int cid = int.Parse(CustomerIdTextBox.Text);
            Customer cust = DAO.searchCustomer(cid);
            if (cust == null) 
            {
                MessageBox.Show("sorry no customer found");
            }
            else 
            {
                nameTextBox.Text = cust.CustomerNavigation.Name;
                addressTextBox.Text = cust.CustomerNavigation.Address;
                telephoneTextBox.Text = cust.CustomerNavigation.Telephone;
                ageTextBox.Text = cust.Age.ToString();
                licenseNumberTextBox.Text = cust.LicenceNumber;
                expiryDatePicker.SelectedDate = cust.LicenceExpiryDate;

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
