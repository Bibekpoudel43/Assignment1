namespace Assignment1
{
    partial class IntervalDetectionSummary
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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.txtIntervalDetection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(402, 12);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 447);
            this.vScrollBar1.TabIndex = 0;
            // 
            // txtIntervalDetection
            // 
            this.txtIntervalDetection.Location = new System.Drawing.Point(12, 12);
            this.txtIntervalDetection.Multiline = true;
            this.txtIntervalDetection.Name = "txtIntervalDetection";
            this.txtIntervalDetection.ReadOnly = true;
            this.txtIntervalDetection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIntervalDetection.Size = new System.Drawing.Size(407, 447);
            this.txtIntervalDetection.TabIndex = 1;
            // 
            // IntervalDetectionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 472);
            this.Controls.Add(this.txtIntervalDetection);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "IntervalDetectionSummary";
            this.Text = "IntervalDetectionSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.TextBox txtIntervalDetection;
    }
}