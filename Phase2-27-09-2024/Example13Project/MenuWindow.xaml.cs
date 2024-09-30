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

namespace Example13Project
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }
        private SumCalcWindow sumcalc = new SumCalcWindow();
        private SquareCalcWindow squarecubecalc = new SquareCalcWindow();
        private CounterWindow counter = new CounterWindow();
        private void btnSumCalc_Click(object sender, RoutedEventArgs e)
        {
            sumcalc.Show();
        }

        private void btnSquareAndCubeCalc_Click(object sender, RoutedEventArgs e)
        {
            squarecubecalc.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter.Show();
        }
    }
}
