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
            this.WeighttextBox = new System.Windows.Forms.TextBox();
            this.Weightlabel = new System.Windows.Forms.Label();
            this.HeighttextBox = new System.Windows.Forms.TextBox();
            this.Heightlabel = new System.Windows.Forms.Label();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.BMIBox = new System.Windows.Forms.TextBox();
            this.BMIbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.twobotton = new System.Windows.Forms.Button();
            this.onebotton = new System.Windows.Forms.Button();
            this.sixbotton = new System.Windows.Forms.Button();
            this.fivebotton = new System.Windows.Forms.Button();
            this.fourbotton = new System.Windows.Forms.Button();
            this.ninebotton = new System.Windows.Forms.Button();
            this.eightbotton = new System.Windows.Forms.Button();
            this.sevenbotton = new System.Windows.Forms.Button();
            this.threebotton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this.UnitButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeighttextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Weightlabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeighttextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Heightlabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ImperialButton, 1, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Salmon;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // UnitButton
            // 
            this.UnitButton.AutoSize = true;
            this.UnitButton.BackColor = System.Drawing.Color.MistyRose;
            this.UnitButton.ForeColor = System.Drawing.Color.Salmon;
            this.UnitButton.Location = new System.Drawing.Point(3, 3);
            this.UnitButton.Name = "UnitButton";
            this.UnitButton.Size = new System.Drawing.Size(150, 35);
            this.UnitButton.TabIndex = 1;
            this.UnitButton.TabStop = true;
            this.UnitButton.Text = "Metric Units";
            this.UnitButton.UseVisualStyleBackColor = false;
            this.UnitButton.CheckedChanged += new System.EventHandler(this.UnitButton_CheckedChanged);
            // 
            // WeighttextBox
            // 
            this.WeighttextBox.Location = new System.Drawing.Point(159, 92);
            this.WeighttextBox.Name = "WeighttextBox";
            this.WeighttextBox.Size = new System.Drawing.Size(100, 38);
            this.WeighttextBox.TabIndex = 5;
            this.WeighttextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            this.WeighttextBox.TextChanged += new System.EventHandler(this.WeighttextBox_TextChanged);
            this.WeighttextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WeightDataMouseDone);
            // 
            // Weightlabel
            // 
            this.Weightlabel.AutoSize = true;
            this.Weightlabel.ForeColor = System.Drawing.Color.Salmon;
            this.Weightlabel.Location = new System.Drawing.Point(3, 89);
            this.Weightlabel.Name = "Weightlabel";
            this.Weightlabel.Size = new System.Drawing.Size(149, 31);
            this.Weightlabel.TabIndex = 6;
            this.Weightlabel.Text = "My Weight:";
            // 
            // HeighttextBox
            // 
            this.HeighttextBox.Location = new System.Drawing.Point(159, 45);
            this.HeighttextBox.Name = "HeighttextBox";
            this.HeighttextBox.Size = new System.Drawing.Size(100, 38);
            this.HeighttextBox.TabIndex = 4;
            this.HeighttextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            this.HeighttextBox.TextChanged += new System.EventHandler(this.HeighttextBox_TextChanged);
            this.HeighttextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeightDataMouseDown);
            // 
            // Heightlabel
            // 
            this.Heightlabel.AutoSize = true;
            this.Heightlabel.ForeColor = System.Drawing.Color.Salmon;
            this.Heightlabel.Location = new System.Drawing.Point(3, 42);
            this.Heightlabel.Name = "Heightlabel";
            this.Heightlabel.Size = new System.Drawing.Size(144, 31);
            this.Heightlabel.TabIndex = 3;
            this.Heightlabel.Text = "My Height:";
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.ForeColor = System.Drawing.Color.Salmon;
            this.ImperialButton.Location = new System.Drawing.Point(159, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(118, 35);
            this.ImperialButton.TabIndex = 2;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // BMIBox
            // 
            this.BMIBox.Location = new System.Drawing.Point(12, 148);
            this.BMIBox.Multiline = true;
            this.BMIBox.Name = "BMIBox";
            this.BMIBox.Size = new System.Drawing.Size(286, 100);
            this.BMIBox.TabIndex = 1;
            this.BMIBox.TabStop = false;
            // 
            // BMIbutton
            // 
            this.BMIbutton.BackColor = System.Drawing.Color.LightCoral;
            this.BMIbutton.Location = new System.Drawing.Point(154, 365);
            this.BMIbutton.Name = "BMIbutton";
            this.BMIbutton.Size = new System.Drawing.Size(144, 41);
            this.BMIbutton.TabIndex = 2;
            this.BMIbutton.Text = "Calculate BMI ";
            this.BMIbutton.UseVisualStyleBackColor = false;
            this.BMIbutton.Click += new System.EventHandler(this.BMIbutton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.84615F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.38462F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.53846F));
            this.tableLayoutPanel2.Controls.Add(this.twobotton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.onebotton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.sixbotton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.fivebotton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fourbotton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ninebotton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.eightbotton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sevenbotton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.threebotton, 2, 2);
            this.tableLayoutPanel2.ForeColor = System.Drawing.Color.LightCoral;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 251);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.92683F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.09756F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.97561F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 164);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // twobotton
            // 
            this.twobotton.Location = new System.Drawing.Point(46, 107);
            this.twobotton.Name = "twobotton";
            this.twobotton.Size = new System.Drawing.Size(37, 48);
            this.twobotton.TabIndex = 7;
            this.twobotton.Tag = "2";
            this.twobotton.Text = "2";
            this.twobotton.UseVisualStyleBackColor = true;
            this.twobotton.Click += new System.EventHandler(this.calculate);
            // 
            // onebotton
            // 
            this.onebotton.Location = new System.Drawing.Point(3, 107);
            this.onebotton.Name = "onebotton";
            this.onebotton.Size = new System.Drawing.Size(37, 48);
            this.onebotton.TabIndex = 6;
            this.onebotton.Tag = "1";
            this.onebotton.Text = "1";
            this.onebotton.UseVisualStyleBackColor = true;
            this.onebotton.Click += new System.EventHandler(this.calculate);
            // 
            // sixbotton
            // 
            this.sixbotton.Location = new System.Drawing.Point(91, 57);
            this.sixbotton.Name = "sixbotton";
            this.sixbotton.Size = new System.Drawing.Size(36, 44);
            this.sixbotton.TabIndex = 5;
            this.sixbotton.Tag = "6";
            this.sixbotton.Text = "6";
            this.sixbotton.UseVisualStyleBackColor = true;
            this.sixbotton.Click += new System.EventHandler(this.calculate);
            // 
            // fivebotton
            // 
            this.fivebotton.Location = new System.Drawing.Point(46, 57);
            this.fivebotton.Name = "fivebotton";
            this.fivebotton.Size = new System.Drawing.Size(37, 44);
            this.fivebotton.TabIndex = 4;
            this.fivebotton.Tag = "5";
            this.fivebotton.Text = "5";
            this.fivebotton.UseVisualStyleBackColor = true;
            this.fivebotton.Click += new System.EventHandler(this.calculate);
            // 
            // fourbotton
            // 
            this.fourbotton.Location = new System.Drawing.Point(3, 57);
            this.fourbotton.Name = "fourbotton";
            this.fourbotton.Size = new System.Drawing.Size(37, 44);
            this.fourbotton.TabIndex = 3;
            this.fourbotton.Tag = "4";
            this.fourbotton.Text = "4";
            this.fourbotton.UseVisualStyleBackColor = true;
            this.fourbotton.Click += new System.EventHandler(this.calculate);
            // 
            // ninebotton
            // 
            this.ninebotton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ninebotton.Location = new System.Drawing.Point(91, 3);
            this.ninebotton.Name = "ninebotton";
            this.ninebotton.Size = new System.Drawing.Size(36, 48);
            this.ninebotton.TabIndex = 2;
            this.ninebotton.Tag = "9";
            this.ninebotton.Text = "9";
            this.ninebotton.UseVisualStyleBackColor = true;
            this.ninebotton.Click += new System.EventHandler(this.calculate);
            // 
            // eightbotton
            // 
            this.eightbotton.Location = new System.Drawing.Point(46, 3);
            this.eightbotton.Name = "eightbotton";
            this.eightbotton.Size = new System.Drawing.Size(37, 48);
            this.eightbotton.TabIndex = 1;
            this.eightbotton.Tag = "8";
            this.eightbotton.Text = "8";
            this.eightbotton.UseVisualStyleBackColor = true;
            this.eightbotton.Click += new System.EventHandler(this.calculate);
            // 
            // sevenbotton
            // 
            this.sevenbotton.Location = new System.Drawing.Point(3, 3);
            this.sevenbotton.Name = "sevenbotton";
            this.sevenbotton.Size = new System.Drawing.Size(37, 48);
            this.sevenbotton.TabIndex = 0;
            this.sevenbotton.Tag = "7";
            this.sevenbotton.Text = "7";
            this.sevenbotton.UseVisualStyleBackColor = true;
            this.sevenbotton.Click += new System.EventHandler(this.calculate);
            // 
            // threebotton
            // 
            this.threebotton.Location = new System.Drawing.Point(91, 107);
            this.threebotton.Name = "threebotton";
            this.threebotton.Size = new System.Drawing.Size(36, 48);
            this.threebotton.TabIndex = 8;
            this.threebotton.Tag = "3";
            this.threebotton.Text = "3";
            this.threebotton.UseVisualStyleBackColor = true;
            this.threebotton.Click += new System.EventHandler(this.calculate);
            // 
            // ResetButton
            // 
            this.ResetButton.ForeColor = System.Drawing.Color.Salmon;
            this.ResetButton.Location = new System.Drawing.Point(154, 292);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(141, 42);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Tag = "Reset";
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.calculate);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.BMIbutton);
            this.Controls.Add(this.BMIBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Bisque;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI";
            this.Click += new System.EventHandler(this.calculate);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button threebotton;
        private System.Windows.Forms.Button twobotton;
        private System.Windows.Forms.Button onebotton;
        private System.Windows.Forms.Button sixbotton;
        private System.Windows.Forms.Button fivebotton;
        private System.Windows.Forms.Button fourbotton;
        private System.Windows.Forms.Button ninebotton;
        private System.Windows.Forms.Button eightbotton;
        private System.Windows.Forms.Button sevenbotton;
        private System.Windows.Forms.Button ResetButton;
    }
}

