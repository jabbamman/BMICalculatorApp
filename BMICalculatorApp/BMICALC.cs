using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorApp
{
    public partial class BMICALC : Form
    {
        public BMICALC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            switch (tag)
            {
                case "Calculate":
                    calculateBMI();
                    break;

                case "Reset":
                    clearForm();
                    break;

            }

        }

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
                bmiResultValidation(_bmival);

            }
        }

        private void bmiResultValidation(double bmival)
        {
            if (bmival < 18.5)
            {
                bmiResultTextBox.Text = "Underweight: less than 18.5";
            }
            else if (bmival >= 18.5 && bmival < 24.9)
            {
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

        private void clearForm()
        {
            metricRadioButton.Checked = false;
            imperialRadioButton.Checked = false;
            heightTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
            bmiTextBox.Text = string.Empty;
            bmiResultTextBox.Text = string.Empty;
        }
    }
}
