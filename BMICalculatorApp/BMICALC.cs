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
                    checkNumericInputs();
                    calculateBMI();
                    break;
                 case "Reset":
                    clearForm();
                    break;
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
                _bmival = _bmiweight / (_bmiheight * _bmiheight);
                _bmival.ToString();
                bmiTextBox.Text += _bmival;
                /// Calling the method that evalutes the range of BMI
                bmiResultValidation(_bmival);
            }
            else
                if (imperialRadioButton.Checked)
            {
                bmiTextBox.Text = string.Empty;
                float _bmiheight;
                float _bmiweight;
                var _bmival = 0.0;
                if (float.TryParse(heightTextBox.Text, out _bmiheight) && (float.TryParse(weightTextBox.Text, out _bmiweight)))

                _bmival = _bmiweight*730 / (_bmiheight * _bmiheight);
                _bmival.ToString();
                bmiTextBox.Text += _bmival;
                /// Calling the method that evalutes the range of BMI
                bmiResultValidation(_bmival);

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
                resultProgressBar.Value = newval;
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
            metricRadioButton.Checked = false;
            imperialRadioButton.Checked = false;
            heightTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
            bmiTextBox.Text = string.Empty;
            bmiResultTextBox.Text = string.Empty;
        }


        /// <summary>
        /// This method is to check the input before process the calculation
        /// the code has been taken from (https://social.msdn.microsoft.com/Forums/en-US/47355657-6e48-4952-8fae-da84960f5fe0/checking-if-textbox-input-is-a-number-or-not?forum=csharplanguage)
        /// </summary>
        private void checkNumericInputs ()
            {
            string _heightString = heightTextBox.Text;
            string _weighString = weightTextBox.Text;
            if (_heightString.Trim() == "" && _weighString.Trim() == "")
            {
                return;
            }

            for (int i = 0; i < _heightString.Length; i++)
            {
                if (!char.IsNumber(_heightString[i]))
                {
                    MessageBox.Show("Please enter a valid number for Height");
                    heightTextBox.Text = string.Empty;
                    return;
                }
            }

            for (int i = 0; i < _weighString.Length; i++)
            {
                if (!char.IsNumber(_weighString[i]))
                {
                    MessageBox.Show("Please enter a valid number for Weight");
                    weightTextBox.Text = string.Empty;
                    return;
                }
            }
        }
    }
}
