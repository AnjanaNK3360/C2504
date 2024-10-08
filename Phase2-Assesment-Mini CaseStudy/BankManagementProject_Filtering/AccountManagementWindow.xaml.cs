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
using System.Windows.Shapes;


namespace BankManagementProject
{
    /// <summary>
    /// Interaction logic for AccountManagementWindow.xaml
    /// </summary>
    public partial class AccountManagementWindow : Window
    {
        public AccountManagementWindow()
        {
            InitializeComponent();
            DataContext = AccountConfig.VueModel;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AccountConfig.FrmAddAccount.Show();
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (grdAccount.SelectedIndex == -1)
            {
                var result = MessageBox.Show(messageBoxText: "Please select Account details to edit",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);
                return;
            }
            AccountConfig.FrmEditAccount.Show();

        }

       

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (grdAccount.SelectedIndex == -1)
            {
                var result = MessageBox.Show(messageBoxText: "Please select Account details to Delete",
                    caption: "Alert",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Information);
                return;
            }
            AccountViewModel viewModel = new AccountViewModel();
            viewModel.Delete();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void cmbFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedFilter = cmbFilter.SelectedItem as string;
            if (selectedFilter != null)
            {
                if (selectedFilter == "All")
                {
                    grdAccount.ItemsSource = (DataContext as AccountViewModel).Accounts;
                }
                else if (selectedFilter == "Savings")
                {
                    grdAccount.ItemsSource = (DataContext as AccountViewModel).Accounts.Where(a => a.AccType == "Savings");
                }
                else if (selectedFilter == "Current")
                {
                    grdAccount.ItemsSource = (DataContext as AccountViewModel).Accounts.Where(a => a.AccType == "Current");
                }
            }

            //(DataContext as AccountViewModel).SelectedFilter = cmbFilter.SelectedItem as string;
            //grdAccount.ItemsSource = (DataContext as AccountViewModel).FilteredAccounts;

            //string selectedFilter = cmbFilter.SelectedValue.ToString();
            //switch (selectedFilter)
            //{
            //    case "All":
            //        grdAccount.ItemsSource = (DataContext as AccountViewModel).Accounts;
            //        break;
            //    case "Savings":
            //        grdAccount.ItemsSource = (DataContext as AccountViewModel).Accounts.Where(a => a.AccType == "Savings");
            //        break;
            //    case "Current":
            //        grdAccount.ItemsSource = (DataContext as AccountViewModel).Accounts.Where(a => a.AccType == "Current");
            //        break;
            //}

            //string selectedFilter = cmbFilter.SelectedValue.ToString();
            //(DataContext as AccountViewModel).SelectedFilter = selectedFilter;
            //grdAccount.ItemsSource = (DataContext as AccountViewModel).FilteredAccounts;


        }
    }
}
