using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calculator
{
    static class Program
    {
        public static StartForm startform;
        public static CalculatorForm calculatorform;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            startform = new StartForm();
            calculatorform = new CalculatorForm();
            Application.Run(startform);
        }
    }
}
