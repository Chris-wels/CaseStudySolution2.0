using CaseStudySolution.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace CaseStudySolution2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerFormxaml form = new AddCustomerFormxaml();
            form.Show();
            this.Hide();
        }

        private void AddEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.Show();
            this.Hide();
        }

        private void SearchCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            SearchCustomerForm form = new SearchCustomerForm();
            form.Show();
            this.Hide();
        }

        private void UpdateCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateCustomerForm form = new UpdateCustomerForm();
            form.Show();
            this.Hide();
        }

        private void ShowCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            ShowCustomerForm form = new ShowCustomerForm();
            form.Show();
            this.Hide();
        }

        private void SearchEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            SearchEmployeeForm form = new SearchEmployeeForm();
            form.Show();
            this.Hide();
        }

        private void UpdateEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateEmployeeForm form = new UpdateEmployeeForm();
            form.Show();
            this.Hide();
        }

        private void ShowEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            ShowEmployeeForm form = new ShowEmployeeForm();
            form.Show();
            this.Hide();
        }
    }
}
