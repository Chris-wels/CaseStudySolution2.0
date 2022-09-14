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
using CaseStudySolution2._0.Controller;//Remember to get these
using CaseStudySolution2._0;

namespace CaseStudySolution.Views
{
    /// <summary>
    /// Interaction logic for ShowEmployeeForm.xaml
    /// </summary>
    public partial class ShowEmployeeForm : Window
    {
        public ShowEmployeeForm()
        {
            InitializeComponent();
        }

        private void ShowEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            //  EmployeeDataGrid.ItemsSource = DAO.showEmployee();
           
           
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = new MainWindow();
            form.Show();
            this.Hide();
        }
    }
}
