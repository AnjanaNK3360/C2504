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
using BankManagementProject;

namespace BankManagementProject
{
    /// <summary>
    /// Interaction logic for AddAccountWindow.xaml
    /// </summary>
    public partial class AddAccountWindow : Window
    {
        public AddAccountWindow()
        {
            InitializeComponent();
            DataContext = AccountConfig.VueModel;

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void SavingsRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            AccountConfig.VueModel.NewAccount.AccType = (string)AccountConfig.FrmAddAccount.SavingsRadiobutton.Content;
        }

        private void CurrentRadiobutton_Checked(object sender, RoutedEventArgs e)
        {
            AccountConfig.VueModel.NewAccount.AccType = (string)AccountConfig.FrmAddAccount.CurrentRadiobutton.Content;
        }
    }
}
