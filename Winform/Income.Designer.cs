namespace Winform
{
    partial class Income
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Income));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToDate = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Import_btn = new System.Windows.Forms.Button();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.Import_btn);
            this.panel1.Controls.Add(this.dgvIncome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ToDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 462);
            this.panel1.TabIndex = 3;
            // 
            // ToDate
            // 
            this.ToDate.AutoSize = true;
            this.ToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.ForeColor = System.Drawing.Color.DimGray;
            this.ToDate.Location = new System.Drawing.Point(260, 34);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(53, 13);
            this.ToDate.TabIndex = 3;
            this.ToDate.Text = "To Date";
            // 
            // fromDate
            // 
            this.fromDate.AutoSize = true;
            this.fromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.ForeColor = System.Drawing.Color.DimGray;
            this.fromDate.Location = new System.Drawing.Point(16, 34);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(65, 13);
            this.fromDate.TabIndex = 2;
            this.fromDate.Text = "From Date";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(319, 34);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(87, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AllowUserToAddRows = false;
            this.dgvIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvIncome.Location = new System.Drawing.Point(75, 149);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersVisible = false;
            this.dgvIncome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncome.Size = new System.Drawing.Size(386, 237);
            this.dgvIncome.TabIndex = 8;
            this.dgvIncome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.Width = 85;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.Width = 68;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Satus";
            this.Column3.Name = "Column3";
            this.Column3.Width = 59;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Verified by";
            this.Column4.Name = "Column4";
            this.Column4.Width = 81;
            // 
            // Import_btn
            // 
            this.Import_btn.Location = new System.Drawing.Point(75, 107);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(150, 36);
            this.Import_btn.TabIndex = 9;
            this.Import_btn.Text = "Import Excel";
            this.Import_btn.UseVisualStyleBackColor = true;
            this.Import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            // 
            // Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Income";
            this.Text = "Income";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ToDate;
        private System.Windows.Forms.Label fromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.OpenFileDialog openFD;
    }
}