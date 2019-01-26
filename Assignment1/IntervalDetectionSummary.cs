using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class IntervalDetectionSummary : Form
    {
        string averages;
        /// <summary>
        /// constructor of this class
        /// </summary>
        /// <param name="chunkeData">recieves the parameter wherever this class is called and initialized</param>
        public IntervalDetectionSummary(string chunkeData)
        {
            this.averages = chunkeData;
            InitializeComponent();
            //display data in a textbox, environmane.newline breaks the line 
            txtIntervalDetection.Text = averages.Replace("\n", Environment.NewLine);
        }
        
    }
}
