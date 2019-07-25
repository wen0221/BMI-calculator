namespace BMI_calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UnitButton = new System.Windows.Forms.RadioButton();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.BMIBox = new System.Windows.Forms.TextBox();
            this.BMIbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.UnitButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImperialButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeighttextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Weightlabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HeighttextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Heightlabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // UnitButton
            // 
            this.UnitButton.AutoSize = true;
            this.UnitButton.Location = new System.Drawing.Point(3, 3);
            this.UnitButton.Name = "UnitButton";
            this.UnitButton.Size = new System.Drawing.Size(150, 35);
            this.UnitButton.TabIndex = 1;
            this.UnitButton.TabStop = true;
            this.UnitButton.Text = "Metric Units";
            this.UnitButton.UseVisualStyleBackColor = true;
            this.UnitButton.CheckedChanged += new System.EventHandler(this.UnitButton_CheckedChanged);
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(3, 44);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialButton.TabIndex = 2;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(159, 144);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(100, 38);
            this.WeighttextBox.TabIndex = 5;
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.Location = new System.Drawing.Point(3, 141);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(149, 31);
            this.Weightlabel.TabIndex = 6;
            this.Weightlabel.Text = "My Weight:";
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(159, 88);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(100, 38);
            this.HeighttextBox.TabIndex = 4;
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.Location = new System.Drawing.Point(3, 85);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(144, 31);
            this.Heightlabel.TabIndex = 3;
            this.Heightlabel.Text = "My Height:";
            // 
            // BMIBox
            // 
            this.BMIBox.Location = new System.Drawing.Point(21, 310);
            this.BMIBox.Multiline = true;
            this.BMIBox.Name = "BMIBox";
            this.BMIBox.Size = new System.Drawing.Size(271, 100);
            this.BMIBox.TabIndex = 1;
            this.BMIBox.TabStop = false;
            // 
            // BMIbutton
            // 
            this.BMIbutton.BackColor = System.Drawing.Color.LightCoral;
            this.BMIbutton.Location = new System.Drawing.Point(21, 236);
            this.BMIbutton.Name = "BMIbutton";
            this.BMIbutton.Size = new System.Drawing.Size(271, 57);
            this.BMIbutton.TabIndex = 2;
            this.BMIbutton.Text = "Calculate BMI ";
            this.BMIbutton.UseVisualStyleBackColor = false;
            this.BMIbutton.Click += new System.EventHandler(this.BMIbutton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMIbutton);
            this.Controls.Add(this.BMIBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton UnitButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.Label Heightlabel;
        private System.Windows.Forms.Label Weightlabel;
        private System.Windows.Forms.TextBox WeighttextBox;
        private System.Windows.Forms.TextBox HeighttextBox;
        private System.Windows.Forms.TextBox BMIBox;
        private System.Windows.Forms.Button BMIbutton;
    }
}

