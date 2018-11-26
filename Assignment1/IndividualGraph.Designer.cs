namespace Assignment1
{
    partial class IndividualGraph
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
            this.zedGraphControl11 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGraphControl11
            // 
            this.zedGraphControl11.IsShowPointValues = false;
            this.zedGraphControl11.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl11.Name = "zedGraphControl11";
            this.zedGraphControl11.PointValueFormat = "G";
            this.zedGraphControl11.Size = new System.Drawing.Size(806, 147);
            this.zedGraphControl11.TabIndex = 0;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.IsShowPointValues = false;
            this.zedGraphControl2.Location = new System.Drawing.Point(12, 165);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.PointValueFormat = "G";
            this.zedGraphControl2.Size = new System.Drawing.Size(806, 134);
            this.zedGraphControl2.TabIndex = 1;
            this.zedGraphControl2.Resize += new System.EventHandler(this.zedGraphControl2_Resize);
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.IsShowPointValues = false;
            this.zedGraphControl3.Location = new System.Drawing.Point(12, 305);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.PointValueFormat = "G";
            this.zedGraphControl3.Size = new System.Drawing.Size(806, 151);
            this.zedGraphControl3.TabIndex = 2;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.IsShowPointValues = false;
            this.zedGraphControl4.Location = new System.Drawing.Point(12, 462);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.PointValueFormat = "G";
            this.zedGraphControl4.Size = new System.Drawing.Size(806, 151);
            this.zedGraphControl4.TabIndex = 3;
            this.zedGraphControl4.Load += new System.EventHandler(this.zedGraphControl4_Load);
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.IsShowPointValues = false;
            this.zedGraphControl5.Location = new System.Drawing.Point(12, 619);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.PointValueFormat = "G";
            this.zedGraphControl5.Size = new System.Drawing.Size(806, 118);
            this.zedGraphControl5.TabIndex = 4;
            // 
            // IndividualGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 749);
            this.Controls.Add(this.zedGraphControl5);
            this.Controls.Add(this.zedGraphControl4);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl11);
            this.Name = "IndividualGraph";
            this.Text = "SummaryGraph";
            this.Load += new System.EventHandler(this.IndividualGraph_Load);
            this.Resize += new System.EventHandler(this.IndividualGraph_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl11;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private ZedGraph.ZedGraphControl zedGraphControl5;
    }
}