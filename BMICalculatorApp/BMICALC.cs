using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Name: Mohamed Ahmed Ali 
/// Student Number: 301036444
/// Project Title: BMI Calculator. 
/// Project Description:  app that allows users to enter their weight
/// and height and whether they are entering these values in Imperial 
/// or Metric units, then calculates and displays the user's body mass index (BMI).
/// </summary>
namespace BMICalculatorApp
{
    public partial class BMICALC : Form
    {
        public BMICALC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for Buttons Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            switch (tag)
            {
                case "Calculate":
                    enteryVerification();
                    calculateBMI();
                    
                    break;
                case "Reset":
                    clearForm();
                    break;
            }
        }

        private void enteryVerification()
        {
            if (heightTextBox.Text == "")
            {
                MessageBox.Show("Height box is empty");
                heightTextBox.Focus();
            }
            else if (weightTextBox.Text == "")
            {
                MessageBox.Show("Weight box is empty");
                heightTextBox.Focus();
            }
           
        }

        /// <summary>
        /// The method that calculates the BMI 
        /// </summary>
        private void calculateBMI()
        {
            if (metricRadioButton.Checked)
            {
                float _bmiheight;
                float _bmiweight;
                var _bmival = 0.0;
                if (float.TryParse(heightTextBox.Text, out _bmiheight) && (float.TryParse(weightTextBox.Text, out _bmiweight)))
                {
                    _bmival = _bmiweight / (_bmiheight * _bmiheight);
                    _bmival.ToString();
                    bmiTextBox.Text += _bmival;
                    /// Calling the method that evalutes the range of BMI
                    bmiResultValidation(_bmival);
                }
            }

            else
                if (imperialRadioButton.Checked)
            {
                bmiTextBox.Text = string.Empty;
                float _bmiheight;
                float _bmiweight;
                var _bmival = 0.0;
                if (float.TryParse(heightTextBox.Text, out _bmiheight) && (float.TryParse(weightTextBox.Text, out _bmiweight)))
                {
                    _bmival = _bmiweight * 730 / (_bmiheight * _bmiheight);
                    _bmival.ToString();
                    bmiTextBox.Text += _bmival;
                    /// Calling the method that evalutes the range of BMI
                    bmiResultValidation(_bmival);
                }
            }
        }
        /// <summary>
        /// Method that evalutes the BMI Range
        /// </summary>
        /// <param name="bmival"></param>
        private void bmiResultValidation(double bmival)
        {
            if (bmival < 18.5)
            {
                bmiResultTextBox.Text = "Underweight: less than 18.5";
            }
            else if (bmival >= 18.5 && bmival < 24.9)
            {
                var newval=0;
                int.TryParse(bmival.ToString(), out newval);
                bmiResultTextBox.Text = "Normal: between 18.5 and 24.9";
            }
            else if (bmival >= 25 && bmival < 29.9)
            {
                bmiResultTextBox.Text = "Overweight: between 25 and 29.9";
            }
            else if (bmival >= 30)
            {
                bmiResultTextBox.Text = "Obese: 30 or greater";
            }
        }

        /// <summary>
        /// The method that clears the form controls 
        /// </summary>
        private void clearForm()
        {
            metricRadioButton.Checked = true;
            imperialRadioButton.Checked = false;
            heightTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
            bmiTextBox.Text = string.Empty;
            bmiResultTextBox.Text = string.Empty;
        }


        /// <summary>
        /// This method is to check the input during change process the calculation
        /// the code has been taken from (https://www.c-sharpcorner.com/forums/text-box-validation-for-numbers-and-decimal-in-c-sharp)
        /// </summary>


        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checkinputdataheigh(e);

        }

        private void Checkinputdataheigh(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (heightTextBox.Text.Length == 0)
                {
                    e.Handled = true;
                }
                // check if there is already exist a '.' , ','
                if (alreadyExist(heightTextBox.Text, ref sepratorChar))
                {
                    e.Handled = true;

                }

                if (Char.IsDigit(e.KeyChar))
                {
                    //check if a coma or dot exist
                    if (alreadyExist(heightTextBox.Text, ref sepratorChar))
                    {
                        int sepratorPosition = heightTextBox.Text.IndexOf(sepratorChar);
                        string afterSepratorString = heightTextBox.Text.Substring(sepratorPosition + 1);
                        if (heightTextBox.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private bool alreadyExist(string text, ref char sepratorChar)
        {
            return false;
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            checInpuWeight(e);
        }

        private void checInpuWeight(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                // check if it's in the beginning of text not accept
                if (weightTextBox.Text.Length == 0)
                {
                    e.Handled = true;
                }
                // check if there is already exist a '.' , ','
                if (alreadyExist(weightTextBox.Text, ref sepratorChar))
                {
                    e.Handled = true;

                }

                if (Char.IsDigit(e.KeyChar))
                {
                    //check if a coma or dot exist
                    if (alreadyExist(weightTextBox.Text, ref sepratorChar))
                    {
                        int sepratorPosition = weightTextBox.Text.IndexOf(sepratorChar);
                        string afterSepratorString = weightTextBox.Text.Substring(sepratorPosition + 1);
                        if (weightTextBox.SelectionStart > sepratorPosition && afterSepratorString.Length > 1)
                        {
                            e.Handled = true;
                        }
                    }
                }
            }
        }
    }
}
