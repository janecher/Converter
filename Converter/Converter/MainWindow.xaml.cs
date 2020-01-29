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

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double to_inch = 0.393;
        const double to_feet = 0.0328;
        const double feet_to_cm = 30.48;
        const double inch_to_cm = 2.54;
        const double to_lb = 2.204;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            double input_data;
            if (comboBoxChooseConvertion.SelectedItem == null)
            {
                MessageBox.Show("Choose the conversion");
            }           
            else if (double.TryParse(input, out input_data))
            {
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromCmToFeetAndInch))
                {
                    int feet = (int)(input_data * to_feet);
                    double inches = Math.Round((input_data * to_feet - feet) * 12);
                    lblResult.Content = feet.ToString() + " feet and " + inches.ToString() + " inches";
                }
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromCmToInch))
                {
                    lblResult.Content = Math.Round(input_data * to_inch,2) + " inches";
                }
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromInchToCm))
                {
                    lblResult.Content = Math.Round((input_data * inch_to_cm),2) + " cm";
                }
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromCelToFahr))
                {
                    lblResult.Content = Math.Round((input_data * 1.8 + 32),2) + " f";
                }
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromFahrToCel))
                {
                    lblResult.Content = Math.Round(((input_data - 32)*5/9),2) + " c";
                }
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromKgToLb))
                {
                    lblResult.Content = Math.Round((input_data * to_lb),2) + " lb";
                }
                if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromLbToKg))
                {
                    lblResult.Content = Math.Round((input_data / to_lb),2) + " kg";
                }
            }
            else
            {
                MessageBox.Show("Incorrect or missing input");
                txtInput.Text = "";
                lblResult.Content = "";
            }       
        }
        private void ComboBoxChooseConvertion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {           
            if (comboBoxChooseConvertion.SelectedItem.Equals(txtBlockFromFeetAndInchToCm))
            {
                FeetAndInchesForm new_feet_and_inches_form = new FeetAndInchesForm();
                new_feet_and_inches_form.Show();                
            }
            
        }
        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "";
            lblResult.Content = "";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
