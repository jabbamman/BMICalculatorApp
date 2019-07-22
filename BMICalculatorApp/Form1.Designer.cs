namespace COMP123_LESSON9B
{
    partial class FORM1
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
            this.CalcBtntableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.donebtn = new System.Windows.Forms.Button();
            this.zerobtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.twobtn = new System.Windows.Forms.Button();
            this.onebtn = new System.Windows.Forms.Button();
            this.sixbtn = new System.Windows.Forms.Button();
            this.fivebtn = new System.Windows.Forms.Button();
            this.fourbtn = new System.Windows.Forms.Button();
            this.ninebtn = new System.Windows.Forms.Button();
            this.eightbtn = new System.Windows.Forms.Button();
            this.Resultlbl = new System.Windows.Forms.Label();
            this.decimalbtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.backspacebtn = new System.Windows.Forms.Button();
            this.sevenbtn = new System.Windows.Forms.Button();
            this.Heightlbl = new System.Windows.Forms.Label();
            this.CalcBtntableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.CalcBtntableLayoutPanel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcBtntableLayoutPanel.Location = new System.Drawing.Point(12, 139);
            this.CalcBtntableLayoutPanel.Name = "CalcBtntableLayoutPanel";
            this.CalcBtntableLayoutPanel.RowCount = 5;
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalcBtntableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalcBtntableLayoutPanel.Size = new System.Drawing.Size(280, 290);
            this.CalcBtntableLayoutPanel.TabIndex = 0;
            // 
            // donebtn
            // 
            this.donebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donebtn.BackColor = System.Drawing.Color.ForestGreen;
            this.donebtn.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.ForeColor = System.Drawing.Color.White;
            this.donebtn.Location = new System.Drawing.Point(213, 177);
            this.donebtn.Name = "donebtn";
            this.CalcBtntableLayoutPanel.SetRowSpan(this.donebtn, 2);
            this.donebtn.Size = new System.Drawing.Size(64, 110);
            this.donebtn.TabIndex = 11;
            this.donebtn.Tag = "done";
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = false;
            this.donebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // zerobtn
            // 
            this.zerobtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zerobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.CalcBtntableLayoutPanel.SetColumnSpan(this.zerobtn, 2);
            this.zerobtn.ForeColor = System.Drawing.Color.White;
            this.zerobtn.Location = new System.Drawing.Point(3, 235);
            this.zerobtn.Name = "zerobtn";
            this.zerobtn.Size = new System.Drawing.Size(134, 52);
            this.zerobtn.TabIndex = 10;
            this.zerobtn.Tag = "0";
            this.zerobtn.Text = "0";
            this.zerobtn.UseVisualStyleBackColor = false;
            this.zerobtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // threebtn
            // 
            this.threebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.threebtn.ForeColor = System.Drawing.Color.White;
            this.threebtn.Location = new System.Drawing.Point(143, 177);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(64, 52);
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
            this.twobtn.Location = new System.Drawing.Point(73, 177);
            this.twobtn.Name = "twobtn";
            this.twobtn.Size = new System.Drawing.Size(64, 52);
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
            this.onebtn.Location = new System.Drawing.Point(3, 177);
            this.onebtn.Name = "onebtn";
            this.onebtn.Size = new System.Drawing.Size(64, 52);
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
            this.sixbtn.Location = new System.Drawing.Point(143, 119);
            this.sixbtn.Name = "sixbtn";
            this.sixbtn.Size = new System.Drawing.Size(64, 52);
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
            this.fivebtn.Location = new System.Drawing.Point(73, 119);
            this.fivebtn.Name = "fivebtn";
            this.fivebtn.Size = new System.Drawing.Size(64, 52);
            this.fivebtn.TabIndex = 4;
            this.fivebtn.Tag = "5";
            this.fivebtn.Text = "5";
            this.fivebtn.UseVisualStyleBackColor = false;
            this.fivebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // fourbtn
            // 
            this.fourbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.fourbtn.ForeColor = System.Drawing.Color.White;
            this.fourbtn.Location = new System.Drawing.Point(3, 119);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(64, 52);
            this.fourbtn.TabIndex = 3;
            this.fourbtn.Tag = "4";
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = false;
            this.fourbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // ninebtn
            // 
            this.ninebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ninebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ninebtn.ForeColor = System.Drawing.Color.White;
            this.ninebtn.Location = new System.Drawing.Point(143, 61);
            this.ninebtn.Name = "ninebtn";
            this.ninebtn.Size = new System.Drawing.Size(64, 52);
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
            this.eightbtn.Location = new System.Drawing.Point(73, 61);
            this.eightbtn.Name = "eightbtn";
            this.eightbtn.Size = new System.Drawing.Size(64, 52);
            this.eightbtn.TabIndex = 1;
            this.eightbtn.Tag = "8";
            this.eightbtn.Text = "8";
            this.eightbtn.UseVisualStyleBackColor = false;
            this.eightbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // Resultlbl
            // 
            this.Resultlbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Resultlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalcBtntableLayoutPanel.SetColumnSpan(this.Resultlbl, 4);
            this.Resultlbl.Font = new System.Drawing.Font("Arial Narrow", 26.25F);
            this.Resultlbl.Location = new System.Drawing.Point(3, 0);
            this.Resultlbl.Name = "Resultlbl";
            this.Resultlbl.Size = new System.Drawing.Size(274, 57);
            this.Resultlbl.TabIndex = 12;
            this.Resultlbl.Tag = "result";
            this.Resultlbl.Text = "0";
            this.Resultlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // decimalbtn
            // 
            this.decimalbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decimalbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.decimalbtn.ForeColor = System.Drawing.Color.White;
            this.decimalbtn.Location = new System.Drawing.Point(143, 235);
            this.decimalbtn.Name = "decimalbtn";
            this.decimalbtn.Size = new System.Drawing.Size(64, 52);
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
            this.clearbtn.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.Color.White;
            this.clearbtn.Location = new System.Drawing.Point(213, 119);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(64, 52);
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
            this.backspacebtn.Image = global::COMP123_LESSON9B.Properties.Resources.backbutton;
            this.backspacebtn.Location = new System.Drawing.Point(213, 61);
            this.backspacebtn.Name = "backspacebtn";
            this.backspacebtn.Size = new System.Drawing.Size(64, 52);
            this.backspacebtn.TabIndex = 15;
            this.backspacebtn.Tag = "back";
            this.backspacebtn.UseVisualStyleBackColor = false;
            this.backspacebtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // sevenbtn
            // 
            this.sevenbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sevenbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.sevenbtn.ForeColor = System.Drawing.Color.White;
            this.sevenbtn.Location = new System.Drawing.Point(3, 61);
            this.sevenbtn.Name = "sevenbtn";
            this.sevenbtn.Size = new System.Drawing.Size(64, 52);
            this.sevenbtn.TabIndex = 1;
            this.sevenbtn.Tag = "7";
            this.sevenbtn.Text = "7";
            this.sevenbtn.UseVisualStyleBackColor = false;
            this.sevenbtn.Click += new System.EventHandler(this.Calculatorbtn_Click);
            // 
            // Heightlbl
            // 
            this.Heightlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heightlbl.Location = new System.Drawing.Point(9, 9);
            this.Heightlbl.Name = "Heightlbl";
            this.Heightlbl.Size = new System.Drawing.Size(280, 37);
            this.Heightlbl.TabIndex = 1;
            this.Heightlbl.Click += new System.EventHandler(this.Heightlbl_Click);
            // 
            // FORM1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.Heightlbl);
            this.Controls.Add(this.CalcBtntableLayoutPanel);
            this.Name = "FORM1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI CALCULATOR ";
            this.Load += new System.EventHandler(this.FORM1_Load);
            this.CalcBtntableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalcBtntableLayoutPanel;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.Button zerobtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button twobtn;
        private System.Windows.Forms.Button onebtn;
        private System.Windows.Forms.Button sixbtn;
        private System.Windows.Forms.Button fivebtn;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Button ninebtn;
        private System.Windows.Forms.Button eightbtn;
        private System.Windows.Forms.Label Resultlbl;
        private System.Windows.Forms.Button decimalbtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button backspacebtn;
        private System.Windows.Forms.Button sevenbtn;
        private System.Windows.Forms.Label Heightlbl;
    }
}

