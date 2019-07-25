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
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
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
            if(BMI<18.5M)
            {
                BMIBox.Text = "BMI: " + BMI + " Underweight";
            }
            else if (BMI >= 18.5M && BMI <= 24.9M)
            {
                BMIBox.Text = "BMI: " + BMI + " Normal";
            }
            else if (BMI >= 25M && BMI <= 29.9M)
            {
                BMIBox.Text = "BMI: " + BMI + " Overweight";
            }
            else if (BMI >= 30M)
            {
                BMIBox.Text = "BMI: " + BMI + " Obese";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculate(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;


            bool numericResult = int.TryParse(tag, out numericValue);

            if (numericResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;

                if (outputString == "0")
                {
                    outputString = tag;
                }
                else if (outputString.Length < maxSize)
                {
                    outputString += tag;
                }

                HeighttextBox.Text = outputString;
                WeighttextBox.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "Reset":
                       ResetNumber();
                        break;                
                }
            }
        }
        private void ResetNumber()
        {
            HeighttextBox.Text = "0";
            WeighttextBox.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }

    }
    
}
