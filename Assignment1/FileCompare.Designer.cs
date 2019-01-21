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
            this.File2GridView = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.file1btn = new System.Windows.Forms.Button();
            this.file2btn = new System.Windows.Forms.Button();
            this.File1GridView = new System.Windows.Forms.DataGridView();
            this.btnCompare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.File2GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.File1GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // file1txt
            // 
            this.file1txt.Location = new System.Drawing.Point(12, 12);
            this.file1txt.Name = "file1txt";
            this.file1txt.Size = new System.Drawing.Size(168, 20);
            this.file1txt.TabIndex = 2;
            // 
            // file2txt
            // 
            this.file2txt.Location = new System.Drawing.Point(12, 38);
            this.file2txt.Name = "file2txt";
            this.file2txt.Size = new System.Drawing.Size(168, 20);
            this.file2txt.TabIndex = 3;
            // 
            // File2GridView
            // 
            this.File2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File2GridView.Location = new System.Drawing.Point(12, 292);
            this.File2GridView.Name = "File2GridView";
            this.File2GridView.Size = new System.Drawing.Size(585, 150);
            this.File2GridView.TabIndex = 5;
            // 
            // file1btn
            // 
            this.file1btn.Location = new System.Drawing.Point(179, 12);
            this.file1btn.Name = "file1btn";
            this.file1btn.Size = new System.Drawing.Size(82, 21);
            this.file1btn.TabIndex = 0;
            this.file1btn.Text = "Browse";
            this.file1btn.UseVisualStyleBackColor = true;
            this.file1btn.Click += new System.EventHandler(this.file1btn_Click);
            // 
            // file2btn
            // 
            this.file2btn.Location = new System.Drawing.Point(179, 36);
            this.file2btn.Name = "file2btn";
            this.file2btn.Size = new System.Drawing.Size(82, 22);
            this.file2btn.TabIndex = 1;
            this.file2btn.Text = "Browse";
            this.file2btn.UseVisualStyleBackColor = true;
            this.file2btn.Click += new System.EventHandler(this.file2btn_Click_1);
            // 
            // File1GridView
            // 
            this.File1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.File1GridView.Location = new System.Drawing.Point(12, 93);
            this.File1GridView.Name = "File1GridView";
            this.File1GridView.Size = new System.Drawing.Size(580, 150);
            this.File1GridView.TabIndex = 4;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(289, 24);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(133, 22);
            this.btnCompare.TabIndex = 6;
            this.btnCompare.Text = "Initiate Comparision";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // FileCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 509);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.File2GridView);
            this.Controls.Add(this.File1GridView);
            this.Controls.Add(this.file2txt);
            this.Controls.Add(this.file1txt);
            this.Controls.Add(this.file2btn);
            this.Controls.Add(this.file1btn);
            this.Name = "FileCompare";
            this.Text = "File_Compare";
            ((System.ComponentModel.ISupportInitialize)(this.File2GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.File1GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file1txt;
        private System.Windows.Forms.TextBox file2txt;
        private System.Windows.Forms.DataGridView File2GridView;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button file1btn;
        private System.Windows.Forms.Button file2btn;
        private System.Windows.Forms.DataGridView File1GridView;
        private System.Windows.Forms.Button btnCompare;
    }
}