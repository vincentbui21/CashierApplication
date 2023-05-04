namespace Winform
{
    partial class Analytics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AnalyticsOption = new System.Windows.Forms.ComboBox();
            this.Progressbar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Filter_btn1 = new System.Windows.Forms.Button();
            this.ToDate = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.Label();
            this.dateTimePicker_B = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_A = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.AnalyticsOption);
            this.panel1.Controls.Add(this.Progressbar);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.Filter_btn1);
            this.panel1.Controls.Add(this.ToDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.dateTimePicker_B);
            this.panel1.Controls.Add(this.dateTimePicker_A);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 462);
            this.panel1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(39, 84);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(684, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // AnalyticsOption
            // 
            this.AnalyticsOption.BackColor = System.Drawing.Color.MistyRose;
            this.AnalyticsOption.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyticsOption.FormattingEnabled = true;
            this.AnalyticsOption.Items.AddRange(new object[] {
            "Sales",
            "Top Product"});
            this.AnalyticsOption.Location = new System.Drawing.Point(467, 33);
            this.AnalyticsOption.Name = "AnalyticsOption";
            this.AnalyticsOption.Size = new System.Drawing.Size(121, 24);
            this.AnalyticsOption.TabIndex = 8;
            this.AnalyticsOption.SelectedIndexChanged += new System.EventHandler(this.AnalyticsOption_SelectedIndexChanged);
            // 
            // Progressbar
            // 
            this.Progressbar.AutoSize = true;
            this.Progressbar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progressbar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Progressbar.Location = new System.Drawing.Point(533, 397);
            this.Progressbar.Name = "Progressbar";
            this.Progressbar.Size = new System.Drawing.Size(100, 19);
            this.Progressbar.TabIndex = 6;
            this.Progressbar.Text = "Progress Bar";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(525, 421);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 23);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 60;
            // 
            // Filter_btn1
            // 
            this.Filter_btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_btn1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn1.ForeColor = System.Drawing.Color.DimGray;
            this.Filter_btn1.Location = new System.Drawing.Point(615, 33);
            this.Filter_btn1.Name = "Filter_btn1";
            this.Filter_btn1.Size = new System.Drawing.Size(75, 23);
            this.Filter_btn1.TabIndex = 4;
            this.Filter_btn1.Text = "Filter";
            this.Filter_btn1.UseVisualStyleBackColor = true;
            this.Filter_btn1.Click += new System.EventHandler(this.Filter_btn1_Click);
            // 
            // ToDate
            // 
            this.ToDate.AutoSize = true;
            this.ToDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.ForeColor = System.Drawing.Color.DimGray;
            this.ToDate.Location = new System.Drawing.Point(257, 34);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(55, 16);
            this.ToDate.TabIndex = 3;
            this.ToDate.Text = "To Date";
            // 
            // fromDate
            // 
            this.fromDate.AutoSize = true;
            this.fromDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.DimGray;
            this.fromDate.Location = new System.Drawing.Point(12, 34);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(72, 16);
            this.fromDate.TabIndex = 2;
            this.fromDate.Text = "From Date";
            // 
            // dateTimePicker_B
            // 
            this.dateTimePicker_B.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_B.Location = new System.Drawing.Point(319, 34);
            this.dateTimePicker_B.Name = "dateTimePicker_B";
            this.dateTimePicker_B.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker_B.TabIndex = 1;
            // 
            // dateTimePicker_A
            // 
            this.dateTimePicker_A.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_A.Location = new System.Drawing.Point(87, 34);
            this.dateTimePicker_A.Name = "dateTimePicker_A";
            this.dateTimePicker_A.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker_A.TabIndex = 1;
            // 
            // Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Analytics";
            this.Text = "Analytics";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Filter_btn1;
        private System.Windows.Forms.Label ToDate;
        private System.Windows.Forms.Label fromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_B;
        private System.Windows.Forms.DateTimePicker dateTimePicker_A;
        private System.Windows.Forms.Label Progressbar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox AnalyticsOption;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}