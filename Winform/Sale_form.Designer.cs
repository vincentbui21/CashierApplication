namespace Winform
{
    partial class Sale_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.product_list_cbb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tempTotal_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pay_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Product_lsv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.sale_name = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.price_lbl);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.product_list_cbb);
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(361, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(202, 308);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // price_lbl
            // 
            this.price_lbl.BackColor = System.Drawing.Color.MistyRose;
            this.price_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.price_lbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.price_lbl.Location = new System.Drawing.Point(73, 77);
            this.price_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(59, 32);
            this.price_lbl.TabIndex = 8;
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(12, 84);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(47, 19);
            this.price.TabIndex = 8;
            this.price.Text = "Price";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(51, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 34);
            this.button5.TabIndex = 7;
            this.button5.Text = "Check";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 223);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Voucher/Discount";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 157);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 24);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "...";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(146, 47);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(48, 24);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCT LIST";
            // 
            // product_list_cbb
            // 
            this.product_list_cbb.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_list_cbb.FormattingEnabled = true;
            this.product_list_cbb.Location = new System.Drawing.Point(4, 46);
            this.product_list_cbb.Margin = new System.Windows.Forms.Padding(2);
            this.product_list_cbb.Name = "product_list_cbb";
            this.product_list_cbb.Size = new System.Drawing.Size(129, 25);
            this.product_list_cbb.Sorted = true;
            this.product_list_cbb.TabIndex = 0;
            this.product_list_cbb.TabStop = false;
            this.product_list_cbb.Text = "Choose here ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.tempTotal_lbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 358);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(346, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // tempTotal_lbl
            // 
            this.tempTotal_lbl.BackColor = System.Drawing.Color.MistyRose;
            this.tempTotal_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempTotal_lbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTotal_lbl.Location = new System.Drawing.Point(287, 15);
            this.tempTotal_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempTotal_lbl.Name = "tempTotal_lbl";
            this.tempTotal_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tempTotal_lbl.Size = new System.Drawing.Size(40, 28);
            this.tempTotal_lbl.TabIndex = 2;
            this.tempTotal_lbl.Text = "0";
            this.tempTotal_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(220, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "TOTAL:";
            // 
            // pay_btn
            // 
            this.pay_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.ForeColor = System.Drawing.Color.DarkGreen;
            this.pay_btn.Location = new System.Drawing.Point(473, 392);
            this.pay_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(90, 32);
            this.pay_btn.TabIndex = 3;
            this.pay_btn.Text = "Pay";
            this.pay_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Red;
            this.delete_btn.Location = new System.Drawing.Point(364, 358);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(91, 32);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // Product_lsv
            // 
            this.Product_lsv.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.Product_lsv.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.Product_lsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Product_lsv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Product_lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Product_lsv.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_lsv.ForeColor = System.Drawing.Color.Black;
            this.Product_lsv.FullRowSelect = true;
            this.Product_lsv.GridLines = true;
            this.Product_lsv.HideSelection = false;
            this.Product_lsv.Location = new System.Drawing.Point(13, 38);
            this.Product_lsv.Margin = new System.Windows.Forms.Padding(2);
            this.Product_lsv.MultiSelect = false;
            this.Product_lsv.Name = "Product_lsv";
            this.Product_lsv.Size = new System.Drawing.Size(348, 309);
            this.Product_lsv.TabIndex = 5;
            this.Product_lsv.TabStop = false;
            this.Product_lsv.UseCompatibleStateImageBehavior = false;
            this.Product_lsv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 74;
            // 
            // quit_btn
            // 
            this.quit_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.ForeColor = System.Drawing.Color.Brown;
            this.quit_btn.Location = new System.Drawing.Point(364, 394);
            this.quit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(91, 32);
            this.quit_btn.TabIndex = 6;
            this.quit_btn.Text = "Quit";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.Lime;
            this.add_btn.Location = new System.Drawing.Point(472, 358);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(90, 32);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "SALE:";
            // 
            // sale_name
            // 
            this.sale_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sale_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_name.Location = new System.Drawing.Point(67, 10);
            this.sale_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sale_name.Name = "sale_name";
            this.sale_name.Size = new System.Drawing.Size(81, 30);
            this.sale_name.TabIndex = 9;
            this.sale_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_lbl
            // 
            this.time_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.time_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(361, 15);
            this.time_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(202, 24);
            this.time_lbl.TabIndex = 10;
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Sale_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(563, 427);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.sale_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.Product_lsv);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Sale_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox product_list_cbb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ListView Product_lsv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label tempTotal_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sale_name;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}