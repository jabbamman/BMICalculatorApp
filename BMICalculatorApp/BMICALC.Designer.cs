namespace BMICalculatorApp
{
    partial class BMICALC
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
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.systemlbl = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.bmiTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.resultProgressBar = new System.Windows.Forms.ProgressBar();
            this.bmiResultTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.85246F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.14754F));
            this.tableLayoutPanel1.Controls.Add(this.metricRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imperialRadioButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.systemlbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.heightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.weightTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bmiTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.calculateButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.bmiLabel, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(305, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(151, 3);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.metricRadioButton.TabIndex = 0;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Location = new System.Drawing.Point(151, 46);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.imperialRadioButton.TabIndex = 1;
            this.imperialRadioButton.TabStop = true;
            this.imperialRadioButton.Text = "Imperial";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // systemlbl
            // 
            this.systemlbl.Location = new System.Drawing.Point(3, 0);
            this.systemlbl.Name = "systemlbl";
            this.tableLayoutPanel1.SetRowSpan(this.systemlbl, 2);
            this.systemlbl.Size = new System.Drawing.Size(142, 66);
            this.systemlbl.TabIndex = 2;
            this.systemlbl.Text = "SYSTEM";
            this.systemlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(151, 89);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(151, 38);
            this.heightTextBox.TabIndex = 6;
            this.heightTextBox.Tag = "Height";
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // heightLabel
            // 
            this.heightLabel.Location = new System.Drawing.Point(3, 86);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(142, 31);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "My Height";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(151, 132);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(151, 38);
            this.weightTextBox.TabIndex = 7;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // weightLabel
            // 
            this.weightLabel.Location = new System.Drawing.Point(3, 129);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(142, 34);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "My Weight";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmiTextBox
            // 
            this.bmiTextBox.BackColor = System.Drawing.Color.White;
            this.bmiTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmiTextBox.Enabled = false;
            this.bmiTextBox.Location = new System.Drawing.Point(151, 175);
            this.bmiTextBox.Name = "bmiTextBox";
            this.bmiTextBox.Size = new System.Drawing.Size(151, 38);
            this.bmiTextBox.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(3, 218);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(142, 38);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Tag = "Calculate";
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(151, 218);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(151, 38);
            this.resetButton.TabIndex = 9;
            this.resetButton.Tag = "Reset";
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // bmiLabel
            // 
            this.bmiLabel.Location = new System.Drawing.Point(3, 172);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(142, 34);
            this.bmiLabel.TabIndex = 10;
            this.bmiLabel.Text = "RESULT";
            this.bmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultProgressBar
            // 
            this.resultProgressBar.Location = new System.Drawing.Point(4, 378);
            this.resultProgressBar.Name = "resultProgressBar";
            this.resultProgressBar.Size = new System.Drawing.Size(296, 38);
            this.resultProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.resultProgressBar.TabIndex = 13;
            this.resultProgressBar.Tag = "df";
            // 
            // bmiResultTextBox
            // 
            this.bmiResultTextBox.Location = new System.Drawing.Point(4, 336);
            this.bmiResultTextBox.Multiline = true;
            this.bmiResultTextBox.Name = "bmiResultTextBox";
            this.bmiResultTextBox.Size = new System.Drawing.Size(296, 36);
            this.bmiResultTextBox.TabIndex = 13;
            // 
            // BMICALC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.bmiResultTextBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.resultProgressBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "BMICALC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.Label systemlbl;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox bmiTextBox;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.ProgressBar resultProgressBar;
        private System.Windows.Forms.TextBox bmiResultTextBox;
    }
}

