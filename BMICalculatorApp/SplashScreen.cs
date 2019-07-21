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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            BMICALC BMICALC = new BMICALC();
            BMICALC.Show();
            Hide();
        }
    }
}
