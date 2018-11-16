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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFile);
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
            this.panelDataGrid.Controls.Add(this.dataGridView);
            this.panelDataGrid.Location = new System.Drawing.Point(357, 27);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(536, 492);
            this.panelDataGrid.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(536, 492);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.avgAltitude);
            this.panel1.Controls.Add(this.maxPower);
            this.panel1.Controls.Add(this.avgPower);
            this.panel1.Controls.Add(this.minHeartRate);
            this.panel1.Controls.Add(this.maxHeartRate);
            this.panel1.Controls.Add(this.avgHeartRate);
            this.panel1.Controls.Add(this.maximumSpeed);
            this.panel1.Controls.Add(this.avgSpeed);
            this.panel1.Controls.Add(this.totalDistance);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 492);
            this.panel1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 238);
            this.listBox1.TabIndex = 28;
            // 
            // avgAltitude
            // 
            this.avgAltitude.AutoSize = true;
            this.avgAltitude.Location = new System.Drawing.Point(265, 465);
            this.avgAltitude.Name = "avgAltitude";
            this.avgAltitude.Size = new System.Drawing.Size(27, 13);
            this.avgAltitude.TabIndex = 27;
            this.avgAltitude.Text = "N/A";
            // 
            // maxPower
            // 
            this.maxPower.AutoSize = true;
            this.maxPower.Location = new System.Drawing.Point(265, 441);
            this.maxPower.Name = "maxPower";
            this.maxPower.Size = new System.Drawing.Size(27, 13);
            this.maxPower.TabIndex = 26;
            this.maxPower.Text = "N/A";
            // 
            // avgPower
            // 
            this.avgPower.AutoSize = true;
            this.avgPower.Location = new System.Drawing.Point(265, 420);
            this.avgPower.Name = "avgPower";
            this.avgPower.Size = new System.Drawing.Size(27, 13);
            this.avgPower.TabIndex = 25;
            this.avgPower.Text = "N/A";
            // 
            // minHeartRate
            // 
            this.minHeartRate.AutoSize = true;
            this.minHeartRate.Location = new System.Drawing.Point(265, 398);
            this.minHeartRate.Name = "minHeartRate";
            this.minHeartRate.Size = new System.Drawing.Size(27, 13);
            this.minHeartRate.TabIndex = 24;
            this.minHeartRate.Text = "N/A";
            // 
            // maxHeartRate
            // 
            this.maxHeartRate.AutoSize = true;
            this.maxHeartRate.Location = new System.Drawing.Point(265, 375);
            this.maxHeartRate.Name = "maxHeartRate";
            this.maxHeartRate.Size = new System.Drawing.Size(27, 13);
            this.maxHeartRate.TabIndex = 23;
            this.maxHeartRate.Text = "N/A";
            // 
            // avgHeartRate
            // 
            this.avgHeartRate.AutoSize = true;
            this.avgHeartRate.Location = new System.Drawing.Point(265, 351);
            this.avgHeartRate.Name = "avgHeartRate";
            this.avgHeartRate.Size = new System.Drawing.Size(27, 13);
            this.avgHeartRate.TabIndex = 22;
            this.avgHeartRate.Text = "N/A";
            // 
            // maximumSpeed
            // 
            this.maximumSpeed.AutoSize = true;
            this.maximumSpeed.Location = new System.Drawing.Point(265, 328);
            this.maximumSpeed.Name = "maximumSpeed";
            this.maximumSpeed.Size = new System.Drawing.Size(27, 13);
            this.maximumSpeed.TabIndex = 21;
            this.maximumSpeed.Text = "N/A";
            // 
            // avgSpeed
            // 
            this.avgSpeed.AutoSize = true;
            this.avgSpeed.Location = new System.Drawing.Point(265, 302);
            this.avgSpeed.Name = "avgSpeed";
            this.avgSpeed.Size = new System.Drawing.Size(27, 13);
            this.avgSpeed.TabIndex = 20;
            this.avgSpeed.Text = "N/A";
            // 
            // totalDistance
            // 
            this.totalDistance.AutoSize = true;
            this.totalDistance.Location = new System.Drawing.Point(265, 277);
            this.totalDistance.Name = "totalDistance";
            this.totalDistance.Size = new System.Drawing.Size(27, 13);
            this.totalDistance.TabIndex = 19;
            this.totalDistance.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(180, 462);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 16);
            this.label18.TabIndex = 18;
            this.label18.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(180, 438);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(180, 417);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(180, 395);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(180, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(12, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(180, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(180, 348);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Average Altitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Maximum Power";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Average Power";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Minimum HeartRate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maximum HeartRate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average HeartRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximum Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.ListBox listBox1;
    }
}

