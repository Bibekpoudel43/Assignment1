namespace Assignment1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.deviceName = new System.Windows.Forms.GroupBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avgAltitude = new System.Windows.Forms.Label();
            this.maxPower = new System.Windows.Forms.Label();
            this.avgPower = new System.Windows.Forms.Label();
            this.minHeartRate = new System.Windows.Forms.Label();
            this.maxHeartRate = new System.Windows.Forms.Label();
            this.avgHeartRate = new System.Windows.Forms.Label();
            this.maximumSpeed = new System.Windows.Forms.Label();
            this.avgSpeed = new System.Windows.Forms.Label();
            this.totalDistance = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIndividualGraph = new System.Windows.Forms.Button();
            this.btnGraph = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tsslbl = new System.Windows.Forms.Label();
            this.nplbl = new System.Windows.Forms.Label();
            this.pblbl = new System.Windows.Forms.Label();
            this.ftplbl = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.iflbl = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbChunk = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.deviceName.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.compareFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFile);
            // 
            // compareFileToolStripMenuItem
            // 
            this.compareFileToolStripMenuItem.Name = "compareFileToolStripMenuItem";
            this.compareFileToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.compareFileToolStripMenuItem.Text = "Compare File";
            this.compareFileToolStripMenuItem.Click += new System.EventHandler(this.onClickComapreFile);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDataGrid.Controls.Add(this.cmbChunk);
            this.panelDataGrid.Controls.Add(this.button1);
            this.panelDataGrid.Controls.Add(this.label27);
            this.panelDataGrid.Controls.Add(this.panel3);
            this.panelDataGrid.Controls.Add(this.dataGridView);
            this.panelDataGrid.Location = new System.Drawing.Point(387, 24);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(531, 517);
            this.panelDataGrid.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(8, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(508, 340);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.deviceName);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnIndividualGraph);
            this.panel1.Controls.Add(this.btnGraph);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 517);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "kmh",
            "mph"});
            this.comboBox1.Location = new System.Drawing.Point(272, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 21);
            this.comboBox1.TabIndex = 57;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(269, 176);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Speed Unit";
            // 
            // deviceName
            // 
            this.deviceName.Controls.Add(this.panelHeader);
            this.deviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceName.Location = new System.Drawing.Point(12, 13);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(275, 150);
            this.deviceName.TabIndex = 56;
            this.deviceName.TabStop = false;
            this.deviceName.Text = "DeviceName";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.LightGray;
            this.panelHeader.Controls.Add(this.label22);
            this.panelHeader.Controls.Add(this.label21);
            this.panelHeader.Controls.Add(this.label23);
            this.panelHeader.Controls.Add(this.label20);
            this.panelHeader.Controls.Add(this.label24);
            this.panelHeader.Controls.Add(this.label19);
            this.panelHeader.Controls.Add(this.lblInterval);
            this.panelHeader.Controls.Add(this.lblStartTime);
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelHeader.Location = new System.Drawing.Point(6, 21);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(259, 121);
            this.panelHeader.TabIndex = 28;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(76, 92);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 16);
            this.label22.TabIndex = 31;
            this.label22.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 15);
            this.label21.TabIndex = 33;
            this.label21.Text = "Interval";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(76, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 16);
            this.label23.TabIndex = 30;
            this.label23.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 15);
            this.label20.TabIndex = 32;
            this.label20.Text = "Start Time";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(76, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(12, 16);
            this.label24.TabIndex = 29;
            this.label24.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 15);
            this.label19.TabIndex = 29;
            this.label19.Text = "Date";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(98, 93);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(26, 15);
            this.lblInterval.TabIndex = 31;
            this.lblInterval.Text = "N/A";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(98, 55);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(26, 15);
            this.lblStartTime.TabIndex = 30;
            this.lblStartTime.Text = "N/A";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(98, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(26, 15);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "N/A";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.LightGray;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(80, 228);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 24);
            this.label25.TabIndex = 55;
            this.label25.Text = "Summary Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.avgAltitude);
            this.panel2.Controls.Add(this.maxPower);
            this.panel2.Controls.Add(this.avgPower);
            this.panel2.Controls.Add(this.minHeartRate);
            this.panel2.Controls.Add(this.maxHeartRate);
            this.panel2.Controls.Add(this.avgHeartRate);
            this.panel2.Controls.Add(this.maximumSpeed);
            this.panel2.Controls.Add(this.avgSpeed);
            this.panel2.Controls.Add(this.totalDistance);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 232);
            this.panel2.TabIndex = 34;
            // 
            // avgAltitude
            // 
            this.avgAltitude.AutoSize = true;
            this.avgAltitude.Location = new System.Drawing.Point(158, 209);
            this.avgAltitude.Name = "avgAltitude";
            this.avgAltitude.Size = new System.Drawing.Size(13, 13);
            this.avgAltitude.TabIndex = 54;
            this.avgAltitude.Text = "0";
            // 
            // maxPower
            // 
            this.maxPower.AutoSize = true;
            this.maxPower.Location = new System.Drawing.Point(158, 185);
            this.maxPower.Name = "maxPower";
            this.maxPower.Size = new System.Drawing.Size(13, 13);
            this.maxPower.TabIndex = 53;
            this.maxPower.Text = "0";
            // 
            // avgPower
            // 
            this.avgPower.AutoSize = true;
            this.avgPower.Location = new System.Drawing.Point(158, 164);
            this.avgPower.Name = "avgPower";
            this.avgPower.Size = new System.Drawing.Size(13, 13);
            this.avgPower.TabIndex = 52;
            this.avgPower.Text = "0";
            // 
            // minHeartRate
            // 
            this.minHeartRate.AutoSize = true;
            this.minHeartRate.Location = new System.Drawing.Point(158, 142);
            this.minHeartRate.Name = "minHeartRate";
            this.minHeartRate.Size = new System.Drawing.Size(13, 13);
            this.minHeartRate.TabIndex = 51;
            this.minHeartRate.Text = "0";
            // 
            // maxHeartRate
            // 
            this.maxHeartRate.AutoSize = true;
            this.maxHeartRate.Location = new System.Drawing.Point(158, 119);
            this.maxHeartRate.Name = "maxHeartRate";
            this.maxHeartRate.Size = new System.Drawing.Size(13, 13);
            this.maxHeartRate.TabIndex = 50;
            this.maxHeartRate.Text = "0";
            // 
            // avgHeartRate
            // 
            this.avgHeartRate.AutoSize = true;
            this.avgHeartRate.Location = new System.Drawing.Point(158, 95);
            this.avgHeartRate.Name = "avgHeartRate";
            this.avgHeartRate.Size = new System.Drawing.Size(13, 13);
            this.avgHeartRate.TabIndex = 49;
            this.avgHeartRate.Text = "0";
            // 
            // maximumSpeed
            // 
            this.maximumSpeed.AutoSize = true;
            this.maximumSpeed.Location = new System.Drawing.Point(158, 72);
            this.maximumSpeed.Name = "maximumSpeed";
            this.maximumSpeed.Size = new System.Drawing.Size(13, 13);
            this.maximumSpeed.TabIndex = 48;
            this.maximumSpeed.Text = "0";
            // 
            // avgSpeed
            // 
            this.avgSpeed.AutoSize = true;
            this.avgSpeed.Location = new System.Drawing.Point(158, 46);
            this.avgSpeed.Name = "avgSpeed";
            this.avgSpeed.Size = new System.Drawing.Size(13, 13);
            this.avgSpeed.TabIndex = 47;
            this.avgSpeed.Text = "0";
            // 
            // totalDistance
            // 
            this.totalDistance.AutoSize = true;
            this.totalDistance.Location = new System.Drawing.Point(158, 21);
            this.totalDistance.Name = "totalDistance";
            this.totalDistance.Size = new System.Drawing.Size(13, 13);
            this.totalDistance.TabIndex = 46;
            this.totalDistance.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(126, 206);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(126, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 16);
            this.label17.TabIndex = 44;
            this.label17.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(126, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(126, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(126, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(126, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(126, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Average Altitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Maximum Power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Average Power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Minimum HeartRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Maximum HeartRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Average HeartRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Maximum Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Average Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Total Distance";
            // 
            // btnIndividualGraph
            // 
            this.btnIndividualGraph.Location = new System.Drawing.Point(132, 182);
            this.btnIndividualGraph.Name = "btnIndividualGraph";
            this.btnIndividualGraph.Size = new System.Drawing.Size(128, 23);
            this.btnIndividualGraph.TabIndex = 30;
            this.btnIndividualGraph.Text = "Individual Graph";
            this.btnIndividualGraph.UseVisualStyleBackColor = true;
            this.btnIndividualGraph.Click += new System.EventHandler(this.btnIndividualGraph_Click);
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(16, 182);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(98, 23);
            this.btnGraph.TabIndex = 29;
            this.btnGraph.Text = "Summary Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.LightGray;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(277, 350);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(177, 24);
            this.label27.TabIndex = 59;
            this.label27.Text = "Advanced Metrics";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.iflbl);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.tsslbl);
            this.panel3.Controls.Add(this.nplbl);
            this.panel3.Controls.Add(this.pblbl);
            this.panel3.Controls.Add(this.ftplbl);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.label51);
            this.panel3.Controls.Add(this.label52);
            this.panel3.Controls.Add(this.label53);
            this.panel3.Controls.Add(this.label54);
            this.panel3.Location = new System.Drawing.Point(233, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(283, 127);
            this.panel3.TabIndex = 58;
            // 
            // tsslbl
            // 
            this.tsslbl.AutoSize = true;
            this.tsslbl.Location = new System.Drawing.Point(208, 83);
            this.tsslbl.Name = "tsslbl";
            this.tsslbl.Size = new System.Drawing.Size(13, 13);
            this.tsslbl.TabIndex = 49;
            this.tsslbl.Text = "0";
            // 
            // nplbl
            // 
            this.nplbl.AutoSize = true;
            this.nplbl.Location = new System.Drawing.Point(208, 60);
            this.nplbl.Name = "nplbl";
            this.nplbl.Size = new System.Drawing.Size(13, 13);
            this.nplbl.TabIndex = 48;
            this.nplbl.Text = "0";
            // 
            // pblbl
            // 
            this.pblbl.AutoSize = true;
            this.pblbl.Location = new System.Drawing.Point(208, 34);
            this.pblbl.Name = "pblbl";
            this.pblbl.Size = new System.Drawing.Size(13, 13);
            this.pblbl.TabIndex = 47;
            this.pblbl.Text = "0";
            // 
            // ftplbl
            // 
            this.ftplbl.AutoSize = true;
            this.ftplbl.Location = new System.Drawing.Point(208, 9);
            this.ftplbl.Name = "ftplbl";
            this.ftplbl.Size = new System.Drawing.Size(13, 13);
            this.ftplbl.TabIndex = 46;
            this.ftplbl.Text = "0";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(176, 57);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(12, 16);
            this.label42.TabIndex = 40;
            this.label42.Text = ":";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(176, 80);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(12, 16);
            this.label43.TabIndex = 39;
            this.label43.Text = ":";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(176, 34);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(12, 16);
            this.label44.TabIndex = 38;
            this.label44.Text = ":";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(176, 7);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(12, 16);
            this.label45.TabIndex = 37;
            this.label45.Text = ":";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(22, 80);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(138, 13);
            this.label51.TabIndex = 31;
            this.label51.Text = "Training Stress Score (TSS)";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(22, 57);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(92, 13);
            this.label52.TabIndex = 30;
            this.label52.Text = "Normalized Power";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(22, 34);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(79, 13);
            this.label53.TabIndex = 29;
            this.label53.Text = "Power Balance";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(22, 10);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(135, 13);
            this.label54.TabIndex = 28;
            this.label54.Text = "Functional Threshold (FTP)";
            // 
            // iflbl
            // 
            this.iflbl.AutoSize = true;
            this.iflbl.Location = new System.Drawing.Point(208, 105);
            this.iflbl.Name = "iflbl";
            this.iflbl.Size = new System.Drawing.Size(13, 13);
            this.iflbl.TabIndex = 52;
            this.iflbl.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(176, 102);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(12, 16);
            this.label29.TabIndex = 51;
            this.label29.Text = ":";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(22, 102);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(97, 13);
            this.label30.TabIndex = 50;
            this.label30.Text = "Intensity Factor (IF)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 61;
            this.button1.Text = "Chunk";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbChunk
            // 
            this.cmbChunk.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbChunk.FormattingEnabled = true;
            this.cmbChunk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbChunk.Location = new System.Drawing.Point(30, 384);
            this.cmbChunk.Name = "cmbChunk";
            this.cmbChunk.Size = new System.Drawing.Size(66, 21);
            this.cmbChunk.TabIndex = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            this.panelDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.deviceName.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnIndividualGraph;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label avgAltitude;
        private System.Windows.Forms.Label maxPower;
        private System.Windows.Forms.Label avgPower;
        private System.Windows.Forms.Label minHeartRate;
        private System.Windows.Forms.Label maxHeartRate;
        private System.Windows.Forms.Label avgHeartRate;
        private System.Windows.Forms.Label maximumSpeed;
        private System.Windows.Forms.Label avgSpeed;
        private System.Windows.Forms.Label totalDistance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox deviceName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStripMenuItem compareFileToolStripMenuItem;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label iflbl;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label tsslbl;
        private System.Windows.Forms.Label nplbl;
        private System.Windows.Forms.Label pblbl;
        private System.Windows.Forms.Label ftplbl;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox cmbChunk;
        private System.Windows.Forms.Button button1;
    }
}

