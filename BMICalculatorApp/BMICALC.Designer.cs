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
            this.CalcBtntableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sevenbtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.threebtn = new System.Windows.Forms.Button();
            this.twobtn = new System.Windows.Forms.Button();
            this.onebtn = new System.Windows.Forms.Button();
            this.sixbtn = new System.Windows.Forms.Button();
            this.fivebtn = new System.Windows.Forms.Button();
            this.ninebtn = new System.Windows.Forms.Button();
            this.eightbtn = new System.Windows.Forms.Button();
            this.decimalbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.backspacebtn = new System.Windows.Forms.Button();
            this.zerobtn = new System.Windows.Forms.Button();
            this.donebtn = new System.Windows.Forms.Button();
            this.fourbtn = new System.Windows.Forms.Button();
            this.Heightlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.CalcBtntableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.36986F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.63014F));
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(152, 3);
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
            this.imperialRadioButton.Location = new System.Drawing.Point(152, 46);
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
            this.heightTextBox.Location = new System.Drawing.Point(152, 89);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(137, 38);
            this.heightTextBox.TabIndex = 6;
            this.heightTextBox.Tag = "Height";
            this.heightTextBox.Click += new System.EventHandler(this.txtbox_click);
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
            this.weightTextBox.Location = new System.Drawing.Point(152, 132);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(137, 38);
            this.weightTextBox.TabIndex = 7;
            this.weightTextBox.Tag = "Weight";
            this.weightTextBox.Click += new System.EventHandler(this.txtbox_click);
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
            this.bmiTextBox.Location = new System.Drawing.Point(152, 175);
            this.bmiTextBox.Name = "bmiTextBox";
            this.bmiTextBox.Size = new System.Drawing.Size(137, 38);
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
            this.resetButton.Location = new System.Drawing.Point(152, 218);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(137, 38);
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
            this.resultProgressBar.Location = new System.Drawing.Point(4, 361);
            this.resultProgressBar.Name = "resultProgressBar";
            this.resultProgressBar.Size = new System.Drawing.Size(289, 38);
            this.resultProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.resultProgressBar.TabIndex = 13;
            this.resultProgressBar.Tag = "df";
            // 
            // bmiResultTextBox
            // 
            this.bmiResultTextBox.Location = new System.Drawing.Point(4, 277);
            this.bmiResultTextBox.Multiline = true;
            this.bmiResultTextBox.Name = "bmiResultTextBox";
            this.bmiResultTextBox.Size = new System.Drawing.Size(289, 78);
            this.bmiResultTextBox.TabIndex = 13;
            // 
            // CalcBtntableLayoutPanel
            // 
            this.CalcBtntableLayoutPanel.ColumnCount = 4;
            this.CalcBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalcBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalcBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalcBtntableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalcBtntableLayoutPanel.Controls.Add(this.sevenbtn, 0, 1);
            this.CalcBtntableLayoutPanel.Controls.Add(this.Resultlbl, 0, 0);
            this.CalcBtntableLayoutPanel.Controls.Add(this.threebtn, 2, 3);
            this.CalcBtntableLayoutPanel.Controls.Add(this.twobtn, 1, 3);
            this.CalcBtntableLayoutPanel.Controls.Add(this.onebtn, 0, 3);
            this.CalcBtntableLayoutPanel.Controls.Add(this.sixbtn, 2, 2);
            this.CalcBtntableLayoutPanel.Controls.Add(this.fivebtn, 1, 2);
            this.CalcBtntableLayoutPanel.Controls.Add(this.ninebtn, 2, 1);
            this.CalcBtntableLayoutPanel.Controls.Add(this.eightbtn, 1, 1);
            this.CalcBtntableLayoutPanel.Controls.Add(this.decimalbtn, 2, 4);
            this.CalcBtntableLayoutPanel.Controls.Add(this.clearbtn, 3, 2);
            this.CalcBtntableLayoutPanel.Controls.Add(this.backspacebtn, 3, 1);
            this.CalcBtntableLayoutPanel.Controls.Add(this.zerobtn, 0, 4);
            this.CalcBtntableLayoutPanel.Controls.Add(this.donebtn, 3, 3);
            this.CalcBtntableLayoutPanel.Controls.Add(this.fourbtn, 0, 2);
            this.CalcBtntableLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtntableLayoutPanel.Location = new System.Drawing.Point(451, 117);
            this.CalcBtntableLayoutPanel.Margin = new System.Windows.Forms.Padding(7);
            this.CalcBtntableLayoutPanel.Name = "CalcBtntableLayoutPanel";
            this.CalcBtntableLayoutPanel.RowCount = 5;
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalcBtntableLayoutPanel.Size = new System.Drawing.Size(292, 219);
            this.CalcBtntableLayoutPanel.TabIndex = 14;
            this.CalcBtntableLayoutPanel.Visible = false;
            // 
            // sevenbtn
            // 
            this.sevenbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.sevenbtn.ForeColor = System.Drawing.Color.White;
            this.sevenbtn.Location = new System.Drawing.Point(7, 50);
            this.sevenbtn.Margin = new System.Windows.Forms.Padding(7);
            this.sevenbtn.Name = "sevenbtn";
            this.sevenbtn.Size = new System.Drawing.Size(59, 29);
            this.sevenbtn.TabIndex = 1;
            this.sevenbtn.Tag = "7";
            this.sevenbtn.Text = "7";
            this.sevenbtn.UseVisualStyleBackColor = false;
            this.sevenbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalcBtntableLayoutPanel.SetColumnSpan(this.Resultlbl, 4);
            this.Resultlbl.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.Resultlbl.Location = new System.Drawing.Point(7, 0);
            this.Resultlbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(278, 43);
            this.Resultlbl.TabIndex = 12;
            this.Resultlbl.Tag = "result";
            this.Resultlbl.Text = "0";
            this.Resultlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // threebtn
            // 
            this.threebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.threebtn.ForeColor = System.Drawing.Color.White;
            this.threebtn.Location = new System.Drawing.Point(153, 136);
            this.threebtn.Margin = new System.Windows.Forms.Padding(7);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(59, 29);
            this.threebtn.TabIndex = 8;
            this.threebtn.Tag = "3";
            this.threebtn.Text = "3";
            this.threebtn.UseVisualStyleBackColor = false;
            this.threebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // twobtn
            // 
            this.twobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.twobtn.ForeColor = System.Drawing.Color.White;
            this.twobtn.Location = new System.Drawing.Point(80, 136);
            this.twobtn.Margin = new System.Windows.Forms.Padding(7);
            this.twobtn.Name = "twobtn";
            this.twobtn.Size = new System.Drawing.Size(59, 29);
            this.twobtn.TabIndex = 7;
            this.twobtn.Tag = "2";
            this.twobtn.Text = "2";
            this.twobtn.UseVisualStyleBackColor = false;
            this.twobtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // onebtn
            // 
            this.onebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.onebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.onebtn.ForeColor = System.Drawing.Color.White;
            this.onebtn.Location = new System.Drawing.Point(7, 136);
            this.onebtn.Margin = new System.Windows.Forms.Padding(7);
            this.onebtn.Name = "onebtn";
            this.onebtn.Size = new System.Drawing.Size(59, 29);
            this.onebtn.TabIndex = 6;
            this.onebtn.Tag = "1";
            this.onebtn.Text = "1";
            this.onebtn.UseVisualStyleBackColor = false;
            this.onebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // sixbtn
            // 
            this.sixbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sixbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.sixbtn.ForeColor = System.Drawing.Color.White;
            this.sixbtn.Location = new System.Drawing.Point(153, 93);
            this.sixbtn.Margin = new System.Windows.Forms.Padding(7);
            this.sixbtn.Name = "sixbtn";
            this.sixbtn.Size = new System.Drawing.Size(59, 29);
            this.sixbtn.TabIndex = 5;
            this.sixbtn.Tag = "6";
            this.sixbtn.Text = "6";
            this.sixbtn.UseVisualStyleBackColor = false;
            this.sixbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // fivebtn
            // 
            this.fivebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fivebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.fivebtn.ForeColor = System.Drawing.Color.White;
            this.fivebtn.Location = new System.Drawing.Point(80, 93);
            this.fivebtn.Margin = new System.Windows.Forms.Padding(7);
            this.fivebtn.Name = "fivebtn";
            this.fivebtn.Size = new System.Drawing.Size(59, 29);
            this.fivebtn.TabIndex = 4;
            this.fivebtn.Tag = "5";
            this.fivebtn.Text = "5";
            this.fivebtn.UseVisualStyleBackColor = false;
            this.fivebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // ninebtn
            // 
            this.ninebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ninebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ninebtn.ForeColor = System.Drawing.Color.White;
            this.ninebtn.Location = new System.Drawing.Point(153, 50);
            this.ninebtn.Margin = new System.Windows.Forms.Padding(7);
            this.ninebtn.Name = "ninebtn";
            this.ninebtn.Size = new System.Drawing.Size(59, 29);
            this.ninebtn.TabIndex = 2;
            this.ninebtn.Tag = "9";
            this.ninebtn.Text = "9";
            this.ninebtn.UseVisualStyleBackColor = false;
            this.ninebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // eightbtn
            // 
            this.eightbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eightbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.eightbtn.ForeColor = System.Drawing.Color.White;
            this.eightbtn.Location = new System.Drawing.Point(80, 50);
            this.eightbtn.Margin = new System.Windows.Forms.Padding(7);
            this.eightbtn.Name = "eightbtn";
            this.eightbtn.Size = new System.Drawing.Size(59, 29);
            this.eightbtn.TabIndex = 1;
            this.eightbtn.Tag = "8";
            this.eightbtn.Text = "8";
            this.eightbtn.UseVisualStyleBackColor = false;
            this.eightbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // decimalbtn
            // 
            this.decimalbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decimalbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.decimalbtn.ForeColor = System.Drawing.Color.White;
            this.decimalbtn.Location = new System.Drawing.Point(153, 179);
            this.decimalbtn.Margin = new System.Windows.Forms.Padding(7);
            this.decimalbtn.Name = "decimalbtn";
            this.decimalbtn.Size = new System.Drawing.Size(59, 33);
            this.decimalbtn.TabIndex = 13;
            this.decimalbtn.Tag = "decimal";
            this.decimalbtn.Text = ".";
            this.decimalbtn.UseVisualStyleBackColor = false;
            this.decimalbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearbtn.BackColor = System.Drawing.Color.Crimson;
            this.clearbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(226, 93);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(7);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(59, 29);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Tag = "clear";
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = false;
            this.clearbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // backspacebtn
            // 
            this.backspacebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backspacebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.backspacebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backspacebtn.ForeColor = System.Drawing.Color.White;
            this.backspacebtn.Location = new System.Drawing.Point(226, 50);
            this.backspacebtn.Margin = new System.Windows.Forms.Padding(7);
            this.backspacebtn.Name = "backspacebtn";
            this.backspacebtn.Size = new System.Drawing.Size(59, 29);
            this.backspacebtn.TabIndex = 15;
            this.backspacebtn.Tag = "back";
            this.backspacebtn.Text = "<<";
            this.backspacebtn.UseVisualStyleBackColor = false;
            this.backspacebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // zerobtn
            // 
            this.zerobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zerobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.CalcBtntableLayoutPanel.SetColumnSpan(this.zerobtn, 2);
            this.zerobtn.ForeColor = System.Drawing.Color.White;
            this.zerobtn.Location = new System.Drawing.Point(7, 179);
            this.zerobtn.Margin = new System.Windows.Forms.Padding(7);
            this.zerobtn.Name = "zerobtn";
            this.zerobtn.Size = new System.Drawing.Size(132, 33);
            this.zerobtn.TabIndex = 10;
            this.zerobtn.Tag = "0";
            this.zerobtn.Text = "0";
            this.zerobtn.UseVisualStyleBackColor = false;
            this.zerobtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // donebtn
            // 
            this.donebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donebtn.BackColor = System.Drawing.Color.ForestGreen;
            this.donebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.ForeColor = System.Drawing.Color.White;
            this.donebtn.Location = new System.Drawing.Point(226, 136);
            this.donebtn.Margin = new System.Windows.Forms.Padding(7);
            this.donebtn.Name = "donebtn";
            this.CalcBtntableLayoutPanel.SetRowSpan(this.donebtn, 2);
            this.donebtn.Size = new System.Drawing.Size(59, 76);
            this.donebtn.TabIndex = 11;
            this.donebtn.Tag = "done";
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = false;
            this.donebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // fourbtn
            // 
            this.fourbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.fourbtn.ForeColor = System.Drawing.Color.White;
            this.fourbtn.Location = new System.Drawing.Point(7, 93);
            this.fourbtn.Margin = new System.Windows.Forms.Padding(7);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(59, 29);
            this.fourbtn.TabIndex = 3;
            this.fourbtn.Tag = "4";
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = false;
            this.fourbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // Heightlbl
            // 
            this.Heightlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlbl.Location = new System.Drawing.Point(324, 370);
            this.Heightlbl.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Heightlbl.Name = "Heightlbl";
            this.Heightlbl.Size = new System.Drawing.Size(90, 35);
            this.Heightlbl.TabIndex = 15;
            this.Heightlbl.Visible = false;
            // 
            // BMICALC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.CalcBtntableLayoutPanel);
            this.Controls.Add(this.Heightlbl);
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
            this.Load += new System.EventHandler(this.BMICALC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CalcBtntableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel CalcBtntableLayoutPanel;
        private System.Windows.Forms.Button sevenbtn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button twobtn;
        private System.Windows.Forms.Button onebtn;
        private System.Windows.Forms.Button sixbtn;
        private System.Windows.Forms.Button fivebtn;
        private System.Windows.Forms.Button ninebtn;
        private System.Windows.Forms.Button eightbtn;
        private System.Windows.Forms.Button decimalbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button backspacebtn;
        private System.Windows.Forms.Button zerobtn;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Label Heightlbl;
    }
}

