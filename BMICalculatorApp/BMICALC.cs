using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace BMICalculatorApp
{
    public partial class BMICALC : Form
    {
        public string outputstring { get; set; }
        public bool decimalExist { get; set; }
        public float outputValue { get; set; }
        public string callingTxtBox { get; set; }
        public BMICALC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the method to load the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BMICALC_Load(object sender, EventArgs e)
        {
            this.Width = 320;
            this.Height = 480;
            this.CenterToScreen();
            clearForm();
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
                    bmiResultToProgressBar();
                    break;
                case "Reset":
                    clearForm();
                    break;
            }
        }
        /// <summary>
        /// This method to reflect the result to the progress bar
        /// </summary>
        private void bmiResultToProgressBar()
        {
            float _bmiResultVar = 0;
            _bmiResultVar = float.Parse(bmiTextBox.Text);
            resultProgressBar.Maximum = 30;
            resultProgressBar.Minimum = 0;
            if (_bmiResultVar > 30)
            {
                _bmiResultVar = 30;
            }

            resultProgressBar.Value = (int)(_bmiResultVar);
        }
        /// <summary>
        /// This method to be called before calculating the bmi to ensure that the field are not empty
        /// </summary>
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
            bmiTextBox.Text = string.Empty;
            bmiResultTextBox.Text = string.Empty;
            if (metricRadioButton.Checked)
            {
                float _bmiheight;
                float _bmiweight;
                var _bmival = 0.0;
                if (float.TryParse(heightTextBox.Text, out _bmiheight) && (float.TryParse(weightTextBox.Text, out _bmiweight)))
                {
                    _bmival = _bmiweight / (_bmiheight * _bmiheight);
                    _bmival.ToString();
                    bmiTextBox.Text += _bmival.ToString("#.##");
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
                    bmiTextBox.Text += _bmival.ToString("#.##");
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
            else if (bmival >= 18.5 && bmival <= 24.99)
            {
                var newval=0;
                int.TryParse(bmival.ToString(), out newval);
                bmiResultTextBox.Text = "Normal: between 18.5 and 24.9";
                
            }
            else if (bmival >= 25 && bmival <= 29.99)
            {
                bmiResultTextBox.Text = "Overweight: between 25 and 29.9";
            }
            else if (bmival >= 30)
            {
                bmiResultTextBox.Text = "Obese: 30 or greater";
            }
        }

        /// <summary>
        /// The method that clears the form controls and to reset values
        /// </summary>
        private void clearForm()
        {
            ClearNumericKeyboard();
            resultProgressBar.Value = 0;
            CalcBtntableLayoutPanel.Visible = false;
            metricRadioButton.Checked = true;
            imperialRadioButton.Checked = false;
            heightTextBox.Text = string.Empty;
            weightTextBox.Text = string.Empty;
            bmiTextBox.Text = string.Empty;
            bmiResultTextBox.Text = string.Empty;
        }

        private void ClearNumericKeyboard()
        {
            Resultlbl.Text = "0";
            outputstring = string.Empty;
            decimalExist = false;
            outputValue = 0.0f;

                       
        }

        /// <summary>
        /// This method is to check the input during change process the calculation
        /// the code has been taken from (https://www.c-sharpcorner.com/forums/text-box-validation-for-numbers-and-decimal-in-c-sharp)
        /// </summary>
        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
        /// Calling the method that forcing the user to enter numeric and seperators only
            Checkinputheight(e);
        }
        private void Checkinputheight(KeyPressEventArgs e)
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
            checkInputWeight(e);
        }
        private void checkInputWeight(KeyPressEventArgs e)
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

        private void Calculatorbtn_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int btnvalue;
            bool resultCondition = int.TryParse(tag, out btnvalue);
            if (resultCondition)
            {
                int maxsize = 3;
                if (decimalExist)
                {
                    maxsize = 5;
                }
               

                if ((outputstring != "0") && (Resultlbl.Text.Count() < maxsize))
                {
                    if (callingTxtBox == "Height")
                    {
                        outputstring += tag;
                        Resultlbl.Text = outputstring;
                        heightTextBox.Text = outputstring;
                        
                    }
                    else if (callingTxtBox == "Weight")
                    {
                        outputstring += tag;
                        Resultlbl.Text = outputstring;
                        weightTextBox.Text = outputstring;
                    }
                    
                }
            }
            switch (tag)
            {
                case "clear":
                    ClearNumericKeyboard();
                    if (callingTxtBox == "Height")
                    {
                        heightTextBox.Text = outputstring;
                    }
                    else if (callingTxtBox == "Weight")
                    {
                        weightTextBox.Text = outputstring;
                    }

                    break;
                case "back":
                    removeLastChar();

                    break;
                case "done":
                    finalizeOutput();
                    ClearNumericKeyboard();

                    break;
                case "decimal":
                    AddDecimalToResultLbl();
                    break;
            }
        }

        private void AddDecimalToResultLbl()
        {
            if (!decimalExist)
            {
                if (Resultlbl.Text == "0")
                {
                    outputstring += "0";
                }
                outputstring += ".";
                decimalExist = true;
            }
        }
        private void finalizeOutput()
        {
            if (outputstring == string.Empty)
            {
                outputstring = "0";
            }
            outputValue = float.Parse(outputstring);
            Heightlbl.Text = outputValue.ToString();
            CalcBtntableLayoutPanel.Visible = false;
            if (callingTxtBox=="Height")
            {
                heightTextBox.Text = Heightlbl.Text;
            }
            else if (callingTxtBox == "Weight")
            {
                weightTextBox.Text = Heightlbl.Text;
            }
        }
        /// <summary>
        /// this method is removing the last char from label
        /// </summary>
        private void removeLastChar()
        {
            if (outputstring.Length > 1)
            {
                var lastChar = outputstring.Substring(outputstring.Length - 1);
                if (lastChar == ".")
                {
                    decimalExist = false;
                }
                outputstring = outputstring.Remove(outputstring.Length - 1);
                Resultlbl.Text = outputstring;

                if (callingTxtBox == "Height")
                {
                 
                    heightTextBox.Text = outputstring;

                }
                else if (callingTxtBox == "Weight")
                {
                   
                    weightTextBox.Text = outputstring;
                }

                
            }
        }
        /// <summary>
        /// This mehod to show the numeric pad based on the selected field
        /// </summary>
        private void heightAndWeightTxtBox_click(object sender, EventArgs e)
        {
            var _theTxtBox = sender as TextBox;
            string _theTxtBoxTag = _theTxtBox.Tag.ToString();
            if (_theTxtBoxTag == "Height")
            {
                CalcBtntableLayoutPanel.Visible = true;
                callingTxtBox = "Height";
                CalcBtntableLayoutPanel.Location= new Point(4,144);
            }
            else if (_theTxtBoxTag == "Weight")
            {
                CalcBtntableLayoutPanel.Visible = true;
                callingTxtBox = "Weight";
                CalcBtntableLayoutPanel.Location = new Point(4, 187);
            }

        }
    }
}
