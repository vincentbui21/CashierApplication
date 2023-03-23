namespace Winform
{
    partial class Sales_Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Yearly = new System.Windows.Forms.Label();
            this.YearlySales = new System.Windows.Forms.Label();
            this.YSdescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MSdescription = new System.Windows.Forms.Label();
            this.MonthlySales = new System.Windows.Forms.Label();
            this.Monthly = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WSdescription = new System.Windows.Forms.Label();
            this.WeeklySales = new System.Windows.Forms.Label();
            this.Weekly = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DSdescription = new System.Windows.Forms.Label();
            this.DailySales = new System.Windows.Forms.Label();
            this.Daily = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.fromDate = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.Label();
            this.Filter_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ItemName = new System.Windows.Forms.Label();
            this.TotalSales = new System.Windows.Forms.Label();
            this.pricebox = new System.Windows.Forms.Label();
            this.qtyBox = new System.Windows.Forms.Label();
            this.QTYleft = new System.Windows.Forms.Label();
            this.RemainingValue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Filter_btn);
            this.panel1.Controls.Add(this.ToDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 462);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.YSdescription);
            this.panel2.Controls.Add(this.YearlySales);
            this.panel2.Controls.Add(this.Yearly);
            this.panel2.Location = new System.Drawing.Point(34, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 100);
            this.panel2.TabIndex = 0;
            // 
            // Yearly
            // 
            this.Yearly.AutoSize = true;
            this.Yearly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yearly.ForeColor = System.Drawing.Color.LightCoral;
            this.Yearly.Location = new System.Drawing.Point(19, 9);
            this.Yearly.Name = "Yearly";
            this.Yearly.Size = new System.Drawing.Size(125, 24);
            this.Yearly.TabIndex = 0;
            this.Yearly.Text = "Yearly Sales";
            // 
            // YearlySales
            // 
            this.YearlySales.AutoSize = true;
            this.YearlySales.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearlySales.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.YearlySales.Location = new System.Drawing.Point(51, 33);
            this.YearlySales.Name = "YearlySales";
            this.YearlySales.Size = new System.Drawing.Size(67, 25);
            this.YearlySales.TabIndex = 0;
            this.YearlySales.Text = "$1234";
            // 
            // YSdescription
            // 
            this.YSdescription.AutoSize = true;
            this.YSdescription.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YSdescription.ForeColor = System.Drawing.Color.White;
            this.YSdescription.Location = new System.Drawing.Point(23, 70);
            this.YSdescription.Name = "YSdescription";
            this.YSdescription.Size = new System.Drawing.Size(121, 30);
            this.YSdescription.TabIndex = 0;
            this.YSdescription.Text = "Showing sales figures\r\n as at today.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.MSdescription);
            this.panel3.Controls.Add(this.MonthlySales);
            this.panel3.Controls.Add(this.Monthly);
            this.panel3.Location = new System.Drawing.Point(218, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 100);
            this.panel3.TabIndex = 0;
            // 
            // MSdescription
            // 
            this.MSdescription.AutoSize = true;
            this.MSdescription.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSdescription.ForeColor = System.Drawing.Color.White;
            this.MSdescription.Location = new System.Drawing.Point(20, 70);
            this.MSdescription.Name = "MSdescription";
            this.MSdescription.Size = new System.Drawing.Size(121, 30);
            this.MSdescription.TabIndex = 0;
            this.MSdescription.Text = "Showing sales figures\r\n as at today.";
            // 
            // MonthlySales
            // 
            this.MonthlySales.AutoSize = true;
            this.MonthlySales.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlySales.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MonthlySales.Location = new System.Drawing.Point(55, 33);
            this.MonthlySales.Name = "MonthlySales";
            this.MonthlySales.Size = new System.Drawing.Size(56, 25);
            this.MonthlySales.TabIndex = 0;
            this.MonthlySales.Text = "$234";
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Monthly.ForeColor = System.Drawing.Color.LightCoral;
            this.Monthly.Location = new System.Drawing.Point(19, 9);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(140, 24);
            this.Monthly.TabIndex = 0;
            this.Monthly.Text = "Monthly Sales";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Controls.Add(this.WSdescription);
            this.panel4.Controls.Add(this.WeeklySales);
            this.panel4.Controls.Add(this.Weekly);
            this.panel4.Location = new System.Drawing.Point(400, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 100);
            this.panel4.TabIndex = 0;
            // 
            // WSdescription
            // 
            this.WSdescription.AutoSize = true;
            this.WSdescription.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WSdescription.ForeColor = System.Drawing.Color.White;
            this.WSdescription.Location = new System.Drawing.Point(20, 70);
            this.WSdescription.Name = "WSdescription";
            this.WSdescription.Size = new System.Drawing.Size(121, 30);
            this.WSdescription.TabIndex = 0;
            this.WSdescription.Text = "Showing sales figures\r\n as at today.";
            // 
            // WeeklySales
            // 
            this.WeeklySales.AutoSize = true;
            this.WeeklySales.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeeklySales.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.WeeklySales.Location = new System.Drawing.Point(51, 33);
            this.WeeklySales.Name = "WeeklySales";
            this.WeeklySales.Size = new System.Drawing.Size(45, 25);
            this.WeeklySales.TabIndex = 0;
            this.WeeklySales.Text = "$34";
            // 
            // Weekly
            // 
            this.Weekly.AutoSize = true;
            this.Weekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weekly.ForeColor = System.Drawing.Color.LightCoral;
            this.Weekly.Location = new System.Drawing.Point(19, 9);
            this.Weekly.Name = "Weekly";
            this.Weekly.Size = new System.Drawing.Size(135, 24);
            this.Weekly.TabIndex = 0;
            this.Weekly.Text = "Weekly Sales";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.DSdescription);
            this.panel5.Controls.Add(this.DailySales);
            this.panel5.Controls.Add(this.Daily);
            this.panel5.Location = new System.Drawing.Point(582, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 100);
            this.panel5.TabIndex = 0;
            // 
            // DSdescription
            // 
            this.DSdescription.AutoSize = true;
            this.DSdescription.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSdescription.ForeColor = System.Drawing.Color.White;
            this.DSdescription.Location = new System.Drawing.Point(20, 70);
            this.DSdescription.Name = "DSdescription";
            this.DSdescription.Size = new System.Drawing.Size(121, 30);
            this.DSdescription.TabIndex = 0;
            this.DSdescription.Text = "Showing sales figures\r\n as at today.";
            // 
            // DailySales
            // 
            this.DailySales.AutoSize = true;
            this.DailySales.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySales.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DailySales.Location = new System.Drawing.Point(51, 33);
            this.DailySales.Name = "DailySales";
            this.DailySales.Size = new System.Drawing.Size(34, 25);
            this.DailySales.TabIndex = 0;
            this.DailySales.Text = "$4";
            // 
            // Daily
            // 
            this.Daily.AutoSize = true;
            this.Daily.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daily.ForeColor = System.Drawing.Color.LightCoral;
            this.Daily.Location = new System.Drawing.Point(19, 9);
            this.Daily.Name = "Daily";
            this.Daily.Size = new System.Drawing.Size(112, 24);
            this.Daily.TabIndex = 0;
            this.Daily.Text = "Daily Sales";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(90, 219);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // fromDate
            // 
            this.fromDate.AutoSize = true;
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.DimGray;
            this.fromDate.Location = new System.Drawing.Point(15, 185);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(65, 13);
            this.fromDate.TabIndex = 2;
            this.fromDate.Text = "From Date";
            // 
            // ToDate
            // 
            this.ToDate.AutoSize = true;
            this.ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.ForeColor = System.Drawing.Color.DimGray;
            this.ToDate.Location = new System.Drawing.Point(15, 225);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(53, 13);
            this.ToDate.TabIndex = 3;
            this.ToDate.Text = "To Date";
            // 
            // Filter_btn
            // 
            this.Filter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter_btn.ForeColor = System.Drawing.Color.DimGray;
            this.Filter_btn.Location = new System.Drawing.Point(351, 198);
            this.Filter_btn.Name = "Filter_btn";
            this.Filter_btn.Size = new System.Drawing.Size(75, 23);
            this.Filter_btn.TabIndex = 4;
            this.Filter_btn.Text = "Filter";
            this.Filter_btn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.TotalSales, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.QTYleft, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemainingValue, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pricebox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.qtyBox, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(60, 257);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.37762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.62238F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 146);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ItemName
            // 
            this.ItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemName.Location = new System.Drawing.Point(3, 17);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(119, 15);
            this.ItemName.TabIndex = 0;
            this.ItemName.Text = "Item Description";
            // 
            // TotalSales
            // 
            this.TotalSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalSales.AutoSize = true;
            this.TotalSales.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSales.Location = new System.Drawing.Point(238, 17);
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.Size = new System.Drawing.Size(119, 15);
            this.TotalSales.TabIndex = 0;
            this.TotalSales.Text = "Total Sales";
            // 
            // pricebox
            // 
            this.pricebox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pricebox.AutoSize = true;
            this.pricebox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricebox.Location = new System.Drawing.Point(128, 17);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(49, 15);
            this.pricebox.TabIndex = 0;
            this.pricebox.Text = "Price";
            // 
            // qtyBox
            // 
            this.qtyBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyBox.AutoSize = true;
            this.qtyBox.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtyBox.Location = new System.Drawing.Point(183, 17);
            this.qtyBox.Name = "qtyBox";
            this.qtyBox.Size = new System.Drawing.Size(49, 15);
            this.qtyBox.TabIndex = 0;
            this.qtyBox.Text = "QTY";
            // 
            // QTYleft
            // 
            this.QTYleft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QTYleft.AutoSize = true;
            this.QTYleft.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QTYleft.Location = new System.Drawing.Point(363, 17);
            this.QTYleft.Name = "QTYleft";
            this.QTYleft.Size = new System.Drawing.Size(119, 15);
            this.QTYleft.TabIndex = 0;
            this.QTYleft.Text = "Qty Remaining";
            // 
            // RemainingValue
            // 
            this.RemainingValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemainingValue.AutoSize = true;
            this.RemainingValue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingValue.Location = new System.Drawing.Point(488, 17);
            this.RemainingValue.Name = "RemainingValue";
            this.RemainingValue.Size = new System.Drawing.Size(122, 15);
            this.RemainingValue.TabIndex = 0;
            this.RemainingValue.Text = "Value of Remainder";
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Sales_Report";
            this.Text = "Sales_Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label DSdescription;
        private System.Windows.Forms.Label DailySales;
        private System.Windows.Forms.Label Daily;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label WSdescription;
        private System.Windows.Forms.Label WeeklySales;
        private System.Windows.Forms.Label Weekly;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label MSdescription;
        private System.Windows.Forms.Label MonthlySales;
        private System.Windows.Forms.Label Monthly;
        private System.Windows.Forms.Label YSdescription;
        private System.Windows.Forms.Label YearlySales;
        private System.Windows.Forms.Label Yearly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TotalSales;
        private System.Windows.Forms.Label QTYleft;
        private System.Windows.Forms.Label RemainingValue;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label pricebox;
        private System.Windows.Forms.Label qtyBox;
        private System.Windows.Forms.Button Filter_btn;
        private System.Windows.Forms.Label ToDate;
        private System.Windows.Forms.Label fromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}