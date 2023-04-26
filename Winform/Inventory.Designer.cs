namespace Winform
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToDate = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kryptonMonthCalendar1 = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.kryptonColorButton1 = new ComponentFactory.Krypton.Toolkit.KryptonColorButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.kryptonColorButton1);
            this.panel1.Controls.Add(this.kryptonMonthCalendar1);
            this.panel1.Controls.Add(this.ToDate);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-4, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 462);
            this.panel1.TabIndex = 2;
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
            // kryptonMonthCalendar1
            // 
            this.kryptonMonthCalendar1.Location = new System.Drawing.Point(562, 18);
            this.kryptonMonthCalendar1.Name = "kryptonMonthCalendar1";
            this.kryptonMonthCalendar1.Size = new System.Drawing.Size(230, 184);
            this.kryptonMonthCalendar1.TabIndex = 5;
            // 
            // kryptonColorButton1
            // 
            this.kryptonColorButton1.Location = new System.Drawing.Point(113, 106);
            this.kryptonColorButton1.Name = "kryptonColorButton1";
            this.kryptonColorButton1.Size = new System.Drawing.Size(330, 25);
            this.kryptonColorButton1.TabIndex = 6;
            this.kryptonColorButton1.Values.ExtraText = "From Product Management";
            this.kryptonColorButton1.Values.Image = ((System.Drawing.Image)(resources.GetObject("kryptonColorButton1.Values.Image")));
            this.kryptonColorButton1.Values.Text = "Load";
            this.kryptonColorButton1.SelectedColorChanged += new System.EventHandler<ComponentFactory.Krypton.Toolkit.ColorEventArgs>(this.kryptonColorButton1_SelectedColorChanged);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ToDate;
        private System.Windows.Forms.Label fromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar kryptonMonthCalendar1;
        private ComponentFactory.Krypton.Toolkit.KryptonColorButton kryptonColorButton1;
    }
}