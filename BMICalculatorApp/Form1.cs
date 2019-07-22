using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_LESSON9B

{
    public partial class FORM1 : Form

  

    {
        public string outputstring { get; set; }
        public bool decimalExist { get; set; }

        public float outputValue { get; set; }
        /// <summary>
        /// this is the constructor
        /// </summary>
        public FORM1()
        {
            InitializeComponent();
        }

        
        

        private void Calculatorbtn_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int btnvalue;
            bool resultCondition = int.TryParse(tag,out btnvalue);
            //Resultlbl.Text = tag;
            // if a user pressed a number button 
            if (resultCondition)
            {
                int maxsize = 3;
                if (decimalExist)
                {
                    maxsize = 5;
                }
                if ((outputstring != "0")&&(Resultlbl.Text.Count()<maxsize))
                {
                    outputstring += tag;
                    Resultlbl.Text = outputstring;
                }
               
                
            }
                switch (tag)
                {
                case "clear":
                    ClearNumericKeyboard();
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
            }
        }

        /// <summary>
        /// this method clear the numeric keyboard
        /// </summary>
        private void ClearNumericKeyboard()
        {
            Resultlbl.Text = "0";
            outputstring = string.Empty;
            decimalExist = false;
            outputValue = 0.0f;
            
        }

        private void FORM1_Load(object sender, EventArgs e)
        {
            ClearNumericKeyboard();
        }

        private void Heightlbl_Click(object sender, EventArgs e)
        {
            CalcBtntableLayoutPanel.Visible = true;
        }
    }
    }

