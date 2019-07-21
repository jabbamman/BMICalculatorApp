using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorApp
{
    static class Program
    {
        /// <summary>
        /// Author's name: Mohamed Ahmed Ali 
        /// Author’s student number: 301036444
        /// Date last Modified: 21 July 2019
        /// Program Title: BMI Calculator. 
        /// Program description:  app that allows users to enter their weight
        /// and height and whether they are entering these values in Imperial 
        /// or Metric units, then calculates and displays the user's body mass index (BMI).
        /// Revision History:
        /// 15 July 2019: Initilization of the program. 
        /// 16 July 2019: Finishing GUI Controls.
        /// 17 July 2019: Updating the Formula & Functionality. 
        /// 18 July 2019: Adding Progress Bar and entry validation.
        /// 20 July 2019: Functionality of Progress Bar.
        /// 21 July 2019: Splash Screen.
        /// 
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }
    }
}
