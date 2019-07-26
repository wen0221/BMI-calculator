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
       public TextBox textbox { get; set; }
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
            HeighttextBox.Text = "m";
            WeighttextBox.Text = "kg";
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            HeighttextBox.Text = "pounds";
            WeighttextBox.Text = "Inc";
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
                

                if (outputString == null)
                {
                    outputString = tag;
                }
                else if(outputString.Length<3)
                {
                    outputString += tag;
                }
                textbox.Text = outputString;
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
            BMIBox.Text = null;
            outputString = null;
            outputValue = 0.0f;
            decimalExists = false;
        }

        private void ActiveLabel_Click(object sender, EventArgs e)
        {

            
        }
        private void HeighttextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void WeighttextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void height(object sender, EventArgs e)
        {
            //HeighttextBox.Text = "0";
            //HeighttextBox.Text = outputString;

        }

        private void HeightDataMouseDown(object sender, MouseEventArgs e)
        {
            //HeighttextBox.Text = null;
            textbox = HeighttextBox;
            HeighttextBox.Clear();
            outputString = "";
        }

        private void WeightDataMouseDone(object sender, MouseEventArgs e)
        {
            //WeighttextBox.Text = null;
            textbox = WeighttextBox;
            WeighttextBox.Clear();
            outputString = "";


        }
    }
    
}
