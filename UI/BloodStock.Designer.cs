namespace BloodBankManagementSystem.UI
{
    partial class BloodStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodStock));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(273, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Stock Availability";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(978, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(63, 47);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bagalkote",
            "Ballari",
            "Bangalore",
            "Belgaum",
            "Bhadravati, Karnataka",
            "Bidar",
            "Bijapur",
            "Chikmagalur",
            "Chitradurga",
            "Davanagere",
            "Dharwad",
            "Gadag-Betageri",
            "Gangavati, Karnataka",
            "Hassan, Karnataka",
            "Hospet",
            "Hubli",
            "Hubli–Dharwad",
            "Kalaburagi",
            "Kolar",
            "Mandya",
            "Mangalore",
            "Mysore",
            "Narasimharaja",
            "Raichur",
            "Ranebennuru",
            "Robertsonpet",
            "Shimoga",
            "Tumkur",
            "Udupi"});
            this.comboBox1.Location = new System.Drawing.Point(449, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 31);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "---Select City---";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A+",
            "A-",
            "O+",
            "O-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "All Blood Groups"});
            this.comboBox2.Location = new System.Drawing.Point(633, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 31);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Text = "All Blood Groups";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 53);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Home";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(187, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Donors";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(98, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Users";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Location = new System.Drawing.Point(225, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 110);
            this.panel2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(131, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Donors";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(131, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 31);
            this.label11.TabIndex = 1;
            this.label11.Text = "100";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label27.Location = new System.Drawing.Point(16, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(87, 67);
            this.label27.TabIndex = 0;
            this.label27.Text = "O-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(10, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 67);
            this.label12.TabIndex = 0;
            this.label12.Text = "O+";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.label25);
            this.panel8.Controls.Add(this.label26);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(10, 139);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 110);
            this.panel8.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DimGray;
            this.label25.Location = new System.Drawing.Point(131, 55);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 23);
            this.label25.TabIndex = 3;
            this.label25.Text = "Donors";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Firebrick;
            this.label26.Location = new System.Drawing.Point(131, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 31);
            this.label26.TabIndex = 1;
            this.label26.Text = "100";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Location = new System.Drawing.Point(10, 255);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 110);
            this.panel6.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(131, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 23);
            this.label19.TabIndex = 3;
            this.label19.Text = "Donors";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Firebrick;
            this.label20.Location = new System.Drawing.Point(131, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 31);
            this.label20.TabIndex = 1;
            this.label20.Text = "100";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(16, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 67);
            this.label21.TabIndex = 0;
            this.label21.Text = "A+";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Location = new System.Drawing.Point(225, 255);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 110);
            this.panel7.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DimGray;
            this.label22.Location = new System.Drawing.Point(131, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 23);
            this.label22.TabIndex = 3;
            this.label22.Text = "Donors";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Firebrick;
            this.label23.Location = new System.Drawing.Point(131, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 31);
            this.label23.TabIndex = 1;
            this.label23.Text = "100";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(13, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(84, 67);
            this.label24.TabIndex = 0;
            this.label24.Text = "A-";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.Controls.Add(this.label40);
            this.panel13.Controls.Add(this.label41);
            this.panel13.Controls.Add(this.label36);
            this.panel13.Location = new System.Drawing.Point(225, 371);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 116);
            this.panel13.TabIndex = 25;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.DimGray;
            this.label40.Location = new System.Drawing.Point(131, 55);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(65, 23);
            this.label40.TabIndex = 3;
            this.label40.Text = "Donors";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Firebrick;
            this.label41.Location = new System.Drawing.Point(131, 24);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(49, 31);
            this.label41.TabIndex = 1;
            this.label41.Text = "100";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label36.Location = new System.Drawing.Point(16, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 67);
            this.label36.TabIndex = 0;
            this.label36.Text = "B-";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label42.Location = new System.Drawing.Point(16, 24);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(96, 67);
            this.label42.TabIndex = 0;
            this.label42.Text = "B+";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.label34);
            this.panel11.Controls.Add(this.label35);
            this.panel11.Controls.Add(this.label42);
            this.panel11.Location = new System.Drawing.Point(10, 371);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 116);
            this.panel11.TabIndex = 26;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.DimGray;
            this.label34.Location = new System.Drawing.Point(131, 55);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(65, 23);
            this.label34.TabIndex = 3;
            this.label34.Text = "Donors";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Firebrick;
            this.label35.Location = new System.Drawing.Point(131, 24);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 31);
            this.label35.TabIndex = 1;
            this.label35.Text = "100";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.Controls.Add(this.label37);
            this.panel12.Controls.Add(this.label38);
            this.panel12.Controls.Add(this.label33);
            this.panel12.Location = new System.Drawing.Point(225, 493);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 118);
            this.panel12.TabIndex = 27;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.DimGray;
            this.label37.Location = new System.Drawing.Point(131, 55);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 23);
            this.label37.TabIndex = 3;
            this.label37.Text = "Donors";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.Firebrick;
            this.label38.Location = new System.Drawing.Point(131, 24);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 31);
            this.label38.TabIndex = 1;
            this.label38.Text = "100";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(9, 24);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 67);
            this.label33.TabIndex = 0;
            this.label33.Text = "AB-";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label39.Location = new System.Drawing.Point(2, 24);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(131, 67);
            this.label39.TabIndex = 0;
            this.label39.Text = "AB+";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.label31);
            this.panel10.Controls.Add(this.label32);
            this.panel10.Controls.Add(this.label39);
            this.panel10.Location = new System.Drawing.Point(10, 493);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 118);
            this.panel10.TabIndex = 28;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.DimGray;
            this.label31.Location = new System.Drawing.Point(131, 55);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 23);
            this.label31.TabIndex = 3;
            this.label31.Text = "Donors";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Firebrick;
            this.label32.Location = new System.Drawing.Point(131, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 31);
            this.label32.TabIndex = 1;
            this.label32.Text = "100";
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Search Blood Component",
            "Whole Blood",
            "Single Donor Platelet",
            "Single Donor Plasma",
            "Sagm Packed Red Blood Cells",
            "Random Donor Platelets",
            "Platelets Additive Solutions",
            "Platelet Rich Plasma",
            "Platelet Concentrate",
            "Plasma",
            "Packed Red Blood Cells",
            "Leuckoreduced RBC",
            "Irradiated RBC",
            "Fresh Frozen Plasma",
            "Cryoprecipitate",
            "Cryo Poor Plasma"});
            this.comboBox3.Location = new System.Drawing.Point(812, 139);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(217, 31);
            this.comboBox3.TabIndex = 30;
            this.comboBox3.Text = "Select Blood Component";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 328);
            this.dataGridView1.TabIndex = 31;
            // 
            // buttonlogin
            // 
            this.buttonlogin.BackColor = System.Drawing.Color.Maroon;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonlogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonlogin.Location = new System.Drawing.Point(675, 188);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(126, 39);
            this.buttonlogin.TabIndex = 32;
            this.buttonlogin.Text = "Search";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // BloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1044, 622);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodStock";
            this.Activated += new System.EventHandler(this.BloodStock_Activated);
            this.Load += new System.EventHandler(this.BloodStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonlogin;
    }
}