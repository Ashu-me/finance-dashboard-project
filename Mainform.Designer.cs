namespace finance_manager_project
{
    partial class Mainform
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblPFM = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblexpense = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btntransection = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPFM
            // 
            this.lblPFM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPFM.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFM.Location = new System.Drawing.Point(178, 11);
            this.lblPFM.Name = "lblPFM";
            this.lblPFM.Size = new System.Drawing.Size(216, 72);
            this.lblPFM.TabIndex = 1;
            this.lblPFM.Text = "Personal Finance Manager";
            // 
            // lblCurrent
            // 
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrent.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(34, 73);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(129, 65);
            this.lblCurrent.TabIndex = 2;
            this.lblCurrent.Text = "Current Balance";
            this.lblCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbltotal
            // 
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(213, 73);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(129, 65);
            this.lbltotal.TabIndex = 3;
            this.lbltotal.Text = "Total Income";
            this.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // lblexpense
            // 
            this.lblexpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblexpense.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpense.Location = new System.Drawing.Point(389, 73);
            this.lblexpense.Name = "lblexpense";
            this.lblexpense.Size = new System.Drawing.Size(139, 65);
            this.lblexpense.TabIndex = 4;
            this.lblexpense.Text = "Total Expenses";
            this.lblexpense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chart1
            // 
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackImageTransparentColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Turquoise;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 155);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackImageTransparentColor = System.Drawing.Color.White;
            series3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.MarkerSize = 6;
            series3.Name = "s1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(367, 173);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 4;
            this.chart1.Text = "Monthly Expenses";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.chart1.Click += new System.EventHandler(this.chtmonth_Click);
            // 
            // btntransection
            // 
            this.btntransection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btntransection.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntransection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntransection.Location = new System.Drawing.Point(418, 166);
            this.btntransection.Name = "btntransection";
            this.btntransection.Size = new System.Drawing.Size(110, 35);
            this.btntransection.TabIndex = 5;
            this.btntransection.Text = "Add Transection";
            this.btntransection.UseVisualStyleBackColor = false;
            this.btntransection.Click += new System.EventHandler(this.btntransection_Click);
            // 
            // btnreports
            // 
            this.btnreports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnreports.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnreports.Location = new System.Drawing.Point(418, 220);
            this.btnreports.Name = "btnreports";
            this.btnreports.Size = new System.Drawing.Size(110, 37);
            this.btnreports.TabIndex = 6;
            this.btnreports.Text = "View Reports";
            this.btnreports.UseVisualStyleBackColor = false;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(418, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Budget Planning";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cyan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(227, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cyan;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(46, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cyan;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(410, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 13);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(567, 343);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnreports);
            this.Controls.Add(this.btntransection);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblexpense);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblPFM);
            this.MaximizeBox = false;
            this.Name = "Mainform";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPFM;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblexpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btntransection;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}