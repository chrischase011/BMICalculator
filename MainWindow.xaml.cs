using BMICalculator.utils;
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

namespace BMICalculator
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Utils utils = new Utils();

            double height = Convert.ToDouble(txtHeight.Text);
            double weight = Convert.ToDouble(txtWeight.Text);

            double _heightConverted = utils.cmToMSquared(height);

            double calc = weight/_heightConverted;

            string res = utils.classification(calc);

            MessageBox.Show("Your BMI: " + calc.ToString("0.00") + "\n\nClassification: " + res,"BMI Calculation", 
                MessageBoxButton.OK, MessageBoxImage.Information);

        }

    }
}
