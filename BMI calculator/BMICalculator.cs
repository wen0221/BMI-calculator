using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UnitButton_CheckedChanged(object sender, EventArgs e)
        {
            HeighttextBox.Text = "Meters";
            WeighttextBox.Text = "Kg";
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            HeighttextBox.Text = "Inches";
            WeighttextBox.Text = "Pounds";
        }

        private void BMIbutton_Click(object sender, EventArgs e)
        { 
            decimal BMI = 0;
            decimal Height = decimal.Parse(HeighttextBox.Text);
            decimal Weight = decimal.Parse(WeighttextBox.Text);
            if(UnitButton.Checked)
            {
                BMI = Weight / (Height * Height);
            }
            else if(ImperialButton.Checked)
            {
                BMI = (Weight * 703) / (Height * Height);
            }
        }
    }
}
