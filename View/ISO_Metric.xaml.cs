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
using Thread_Calculator.ViewModel;

namespace Thread_Calculator
{
    /// <summary>
    /// Interaction logic for ISO_Metric.xaml
    /// </summary>
    public partial class ISO_Metric : Window
    {
        private ISO_Metric_VM vm;
        public ISO_Metric()
        {
            InitializeComponent();
            this.vm = new ISO_Metric_VM();
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.Show();
        }

        private void cBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            vm.ComboBoxText = cBox.SelectedItem.ToString();
        }

        private void NormalRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SizeTxtBox.IsEnabled = false;
            PitchTxtBox.IsEnabled = false;
            cBox.IsEnabled = true;
            btn.IsEnabled = true;
        }

        private void CustomRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            cBox.IsEnabled = false;
            cBox.SelectedItem = "";
            SizeTxtBox.IsEnabled = true;
            PitchTxtBox.IsEnabled = true;
            btn.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            vm.Close();
        }
    }
}
