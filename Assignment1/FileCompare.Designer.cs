namespace Assignment1
{
    partial class FileCompare
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
            this.file1txt = new System.Windows.Forms.TextBox();
            this.file2txt = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.file1btn = new System.Windows.Forms.Button();
            this.file2btn = new System.Windows.Forms.Button();
            this.File1GridView = new System.Windows.Forms.DataGridView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSummaryGraph = new System.Windows.Forms.Button();
            this.File2GridView = new System.Windows.Forms.DataGridView();
            this.deviceName = new System.Windows.Forms.Label();
            this.deviceName1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.File1GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File2GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // file1txt
            // 
            this.file1txt.Location = new System.Drawing.Point(37, 20);
            this.file1txt.Name = "file1txt";
            this.file1txt.Size = new System.Drawing.Size(168, 20);
            this.file1txt.TabIndex = 2;
            // 
            // file2txt
            // 
            this.file2txt.Location = new System.Drawing.Point(37, 44);
            this.file2txt.Name = "file2txt";
            this.file2txt.Size = new System.Drawing.Size(168, 20);
            this.file2txt.TabIndex = 3;
            // 
            // file1btn
            // 
            this.file1btn.Location = new System.Drawing.Point(204, 20);
            this.file1btn.Name = "file1btn";
            this.file1btn.Size = new System.Drawing.Size(82, 21);
            this.file1btn.TabIndex = 0;
            this.file1btn.Text = "Browse";
            this.file1btn.UseVisualStyleBackColor = true;
            this.file1btn.Click += new System.EventHandler(this.file1btn_Click);
            // 
            // file2btn
            // 
            this.file2btn.Location = new System.Drawing.Point(204, 44);
            this.file2btn.Name = "file2btn";
            this.file2btn.Size = new System.Drawing.Size(82, 22);
            this.file2btn.TabIndex = 1;
            this.file2btn.Text = "Browse";
            this.file2btn.UseVisualStyleBackColor = true;
            this.file2btn.Click += new System.EventHandler(this.file2btn_Click_1);
            // 
            // File1GridView
            // 
            this.File1GridView.AccessibleDescription = "public";
            this.File1GridView.AccessibleName = "File1GridView";
            this.File1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File1GridView.Location = new System.Drawing.Point(12, 101);
            this.File1GridView.Name = "File1GridView";
            this.File1GridView.Size = new System.Drawing.Size(451, 160);
            this.File1GridView.TabIndex = 4;
            this.File1GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.File1GridView_CellClick);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(314, 32);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(133, 22);
            this.btnCompare.TabIndex = 6;
            this.btnCompare.Text = "Initiate Comparision";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSummaryGraph
            // 
            this.btnSummaryGraph.Location = new System.Drawing.Point(330, 280);
            this.btnSummaryGraph.Name = "btnSummaryGraph";
            this.btnSummaryGraph.Size = new System.Drawing.Size(133, 22);
            this.btnSummaryGraph.TabIndex = 7;
            this.btnSummaryGraph.Text = "View Graph";
            this.btnSummaryGraph.UseVisualStyleBackColor = true;
            this.btnSummaryGraph.Click += new System.EventHandler(this.btnSummaryGraph_Click);
            // 
            // File2GridView
            // 
            this.File2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File2GridView.Location = new System.Drawing.Point(12, 321);
            this.File2GridView.Name = "File2GridView";
            this.File2GridView.Size = new System.Drawing.Size(451, 160);
            this.File2GridView.TabIndex = 8;
            // 
            // deviceName
            // 
            this.deviceName.AutoSize = true;
            this.deviceName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceName.Location = new System.Drawing.Point(12, 79);
            this.deviceName.Name = "deviceName";
            this.deviceName.Size = new System.Drawing.Size(96, 19);
            this.deviceName.TabIndex = 9;
            this.deviceName.Text = "DeviceName";
            // 
            // deviceName1
            // 
            this.deviceName1.AutoSize = true;
            this.deviceName1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deviceName1.Location = new System.Drawing.Point(12, 299);
            this.deviceName1.Name = "deviceName1";
            this.deviceName1.Size = new System.Drawing.Size(96, 19);
            this.deviceName1.TabIndex = 10;
            this.deviceName1.Text = "DeviceName";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(495, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 222);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Difference of Each Selected Row";
            // 
            // FileCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 509);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deviceName1);
            this.Controls.Add(this.deviceName);
            this.Controls.Add(this.File2GridView);
            this.Controls.Add(this.btnSummaryGraph);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.File1GridView);
            this.Controls.Add(this.file2txt);
            this.Controls.Add(this.file1txt);
            this.Controls.Add(this.file2btn);
            this.Controls.Add(this.file1btn);
            this.Name = "FileCompare";
            this.Text = "File_Compare";
            ((System.ComponentModel.ISupportInitialize)(this.File1GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File2GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file1txt;
        private System.Windows.Forms.TextBox file2txt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button file1btn;
        private System.Windows.Forms.Button file2btn;
        private System.Windows.Forms.DataGridView File1GridView;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSummaryGraph;
        private System.Windows.Forms.DataGridView File2GridView;
        private System.Windows.Forms.Label deviceName;
        private System.Windows.Forms.Label deviceName1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}