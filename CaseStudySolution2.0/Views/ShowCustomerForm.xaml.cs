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
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CaseStudySolution2._0;

namespace CaseStudySolution.Views
{
    /// <summary>
    /// Interaction logic for ShowCustomerForm.xaml
    /// </summary>
    public partial class ShowCustomerForm : Window
    {
        public ShowCustomerForm()
        {
            InitializeComponent();
        }

        private void ShowCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext()) 
            {
                CustomerDataGrid.ItemsSource = (from c in ctx.Customers
                                                join cp in ctx.People on c.CustomerId equals cp.Id
                                                select new
                                                {cp.Name,
                                                cp.Address,
                                                cp.Telephone,
                                                c.CustomerId,
                                                c.Age,
                                                c.LicenceNumber,
                                                c.LicenceExpiryDate,
                                                }
                                                ).ToString();
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
