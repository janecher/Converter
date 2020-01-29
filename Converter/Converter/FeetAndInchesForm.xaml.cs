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

namespace Converter
{
    /// <summary>
    /// Interaction logic for FeetAndInchesForm.xaml
    /// </summary>
    public partial class FeetAndInchesForm : Window
    {
        public double number_of_feet;
        public double number_of_inches;
        public double cm_result;
        const double feet_to_cm = 30.48;
        const double inch_to_cm = 2.54;
        public FeetAndInchesForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            string input_feet = txtBoxFeet.Text;
            string input_inches = txtBoxInches.Text;
            if (String.IsNullOrEmpty(input_feet))
            {
                MessageBox.Show("Input number of feet");
                txtBoxFeet.Text = "";
            }
            else if (String.IsNullOrEmpty(input_inches))
            {
                MessageBox.Show("Input number of inches");
                txtBoxInches.Text = "";
            }
            else if (double.TryParse(input_feet, out number_of_feet) && double.TryParse(input_inches, out number_of_inches))
            {
                cm_result = number_of_feet * feet_to_cm + number_of_inches * inch_to_cm;
                lblFeetAndInchResult.Content = cm_result.ToString() + " cm";
            }
            else
            {
                MessageBox.Show("Incorrect inputs");
                txtBoxFeet.Text = "";
                txtBoxInches.Text = "";
            }
        }

        private void btnFeetAndInchClean_Click(object sender, RoutedEventArgs e)
        {
            txtBoxFeet.Text = "";
            txtBoxInches.Text = "";
            lblFeetAndInchResult.Content = "";

        }

        private void btnFeetAndInchExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
