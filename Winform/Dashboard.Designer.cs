namespace Winform
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Settings_btn = new System.Windows.Forms.Button();
            this.Invoices_btn = new System.Windows.Forms.Button();
            this.Sales_btn = new System.Windows.Forms.Button();
            this.Analytics_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.user_namebox = new System.Windows.Forms.Label();
            this.ImagePanel_btn = new System.Windows.Forms.Panel();
            this.NavPanel_lbl = new System.Windows.Forms.Panel();
            this.User_Name = new System.Windows.Forms.Label();
            this.User_photo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 488);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel8.Controls.Add(this.circularProgressBar1);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(159, 209);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(241, 262);
            this.panel8.TabIndex = 5;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Ebrima", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.DarkSlateGray;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(48, 39);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.circularProgressBar1.ProgressWidth = 7;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(150, 150);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "67%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Progress bar";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(30, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "Details of the last 28 days \r\nshows a 67% increase in sales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.Controls.Add(this.chart1);
            this.panel9.Controls.Add(this.label11);
            this.panel9.Location = new System.Drawing.Point(416, 209);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(323, 189);
            this.panel9.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkSlateGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 129);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(19, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Progress Graph";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label13);
            this.panel10.Location = new System.Drawing.Point(658, 63);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(81, 130);
            this.panel10.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label8.Location = new System.Drawing.Point(8, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 51);
            this.label8.TabIndex = 4;
            this.label8.Text = "Restock \r\nlevel \r\nok";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(3, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Inventory";
            this.label13.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.pictureBox4);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Location = new System.Drawing.Point(416, 404);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(323, 67);
            this.panel11.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label9.Location = new System.Drawing.Point(3, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Details of the last 28 days";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(219, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(88, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 25);
            this.label15.TabIndex = 0;
            this.label15.Text = "Top Product Sales";
            this.label15.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(159, 63);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(482, 130);
            this.panel6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label12.Location = new System.Drawing.Point(104, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Details of the last 28 days";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(369, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(167, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Income";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(714, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.SearchBox.Font = new System.Drawing.Font("Corbel Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(465, 16);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(225, 27);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.Text = "search for something...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(154, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Settings_btn);
            this.panel2.Controls.Add(this.Invoices_btn);
            this.panel2.Controls.Add(this.Sales_btn);
            this.panel2.Controls.Add(this.Analytics_btn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 488);
            this.panel2.TabIndex = 0;
            // 
            // Settings_btn
            // 
            this.Settings_btn.FlatAppearance.BorderSize = 0;
            this.Settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Settings_btn.Image = global::Winform.Properties.Resources.settings;
            this.Settings_btn.Location = new System.Drawing.Point(-2, 427);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(148, 38);
            this.Settings_btn.TabIndex = 3;
            this.Settings_btn.Text = "Settings";
            this.Settings_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Settings_btn.UseVisualStyleBackColor = true;
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            this.Settings_btn.Leave += new System.EventHandler(this.Settings_btn_Leave);
            // 
            // Invoices_btn
            // 
            this.Invoices_btn.FlatAppearance.BorderSize = 0;
            this.Invoices_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Invoices_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoices_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Invoices_btn.Image = ((System.Drawing.Image)(resources.GetObject("Invoices_btn.Image")));
            this.Invoices_btn.Location = new System.Drawing.Point(-7, 306);
            this.Invoices_btn.Name = "Invoices_btn";
            this.Invoices_btn.Size = new System.Drawing.Size(148, 38);
            this.Invoices_btn.TabIndex = 3;
            this.Invoices_btn.Text = "Invoices";
            this.Invoices_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Invoices_btn.UseVisualStyleBackColor = true;
            this.Invoices_btn.Click += new System.EventHandler(this.Expenditure_btn_Click);
            this.Invoices_btn.Leave += new System.EventHandler(this.Expenditure_btn_Leave);
            // 
            // Sales_btn
            // 
            this.Sales_btn.FlatAppearance.BorderSize = 0;
            this.Sales_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Sales_btn.Image = ((System.Drawing.Image)(resources.GetObject("Sales_btn.Image")));
            this.Sales_btn.Location = new System.Drawing.Point(0, 230);
            this.Sales_btn.Name = "Sales_btn";
            this.Sales_btn.Size = new System.Drawing.Size(148, 38);
            this.Sales_btn.TabIndex = 3;
            this.Sales_btn.Text = "Sales";
            this.Sales_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Sales_btn.UseVisualStyleBackColor = true;
            this.Sales_btn.Click += new System.EventHandler(this.Sales_btn_Click);
            this.Sales_btn.Leave += new System.EventHandler(this.Sales_btn_Leave);
            // 
            // Analytics_btn
            // 
            this.Analytics_btn.FlatAppearance.BorderSize = 0;
            this.Analytics_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Analytics_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analytics_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.Analytics_btn.Image = global::Winform.Properties.Resources.diagram;
            this.Analytics_btn.Location = new System.Drawing.Point(1, 160);
            this.Analytics_btn.Name = "Analytics_btn";
            this.Analytics_btn.Size = new System.Drawing.Size(148, 38);
            this.Analytics_btn.TabIndex = 3;
            this.Analytics_btn.Text = "Analytics";
            this.Analytics_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Analytics_btn.UseVisualStyleBackColor = true;
            this.Analytics_btn.Click += new System.EventHandler(this.Analytics_btn_Click);
            this.Analytics_btn.Leave += new System.EventHandler(this.Analytics_btn_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Snow;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.user_namebox);
            this.panel5.Controls.Add(this.ImagePanel_btn);
            this.panel5.Controls.Add(this.NavPanel_lbl);
            this.panel5.Controls.Add(this.User_Name);
            this.panel5.Controls.Add(this.User_photo);
            this.panel5.Location = new System.Drawing.Point(-2, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 126);
            this.panel5.TabIndex = 1;
            // 
            // user_namebox
            // 
            this.user_namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_namebox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_namebox.Location = new System.Drawing.Point(18, 86);
            this.user_namebox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.user_namebox.Name = "user_namebox";
            this.user_namebox.Size = new System.Drawing.Size(81, 23);
            this.user_namebox.TabIndex = 10;
            this.user_namebox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.user_namebox.Click += new System.EventHandler(this.user_namebox_Click);
            // 
            // ImagePanel_btn
            // 
            this.ImagePanel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ImagePanel_btn.Location = new System.Drawing.Point(0, 193);
            this.ImagePanel_btn.Name = "ImagePanel_btn";
            this.ImagePanel_btn.Size = new System.Drawing.Size(3, 100);
            this.ImagePanel_btn.TabIndex = 2;
            // 
            // NavPanel_lbl
            // 
            this.NavPanel_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NavPanel_lbl.Location = new System.Drawing.Point(0, 193);
            this.NavPanel_lbl.Name = "NavPanel_lbl";
            this.NavPanel_lbl.Size = new System.Drawing.Size(3, 100);
            this.NavPanel_lbl.TabIndex = 2;
            // 
            // User_Name
            // 
            this.User_Name.AutoSize = true;
            this.User_Name.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(249)))));
            this.User_Name.Location = new System.Drawing.Point(28, 71);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(71, 15);
            this.User_Name.TabIndex = 2;
            this.User_Name.Text = "User Name";
            // 
            // User_photo
            // 
            this.User_photo.BackColor = System.Drawing.Color.Snow;
            this.User_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.User_photo.Image = global::Winform.Properties.Resources.Untitled_11;
            this.User_photo.Location = new System.Drawing.Point(31, 9);
            this.User_photo.Name = "User_photo";
            this.User_photo.Size = new System.Drawing.Size(80, 58);
            this.User_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.User_photo.TabIndex = 1;
            this.User_photo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Snow;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(-2, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 10);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Snow;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(3, 481);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(84, 10);
            this.panel3.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 483);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label User_Name;
        private System.Windows.Forms.PictureBox User_photo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Settings_btn;
        private System.Windows.Forms.Button Sales_btn;
        private System.Windows.Forms.Button Analytics_btn;
        private System.Windows.Forms.Panel NavPanel_lbl;
        private System.Windows.Forms.Panel ImagePanel_btn;
        private System.Windows.Forms.Button Invoices_btn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label user_namebox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}