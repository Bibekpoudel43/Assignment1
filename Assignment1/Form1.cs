using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile(object sender, EventArgs e)
        {
            ReadFromFile();
        }


        //read the value from the file
        //state load function
        private List<string> ReadFromFile()
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Text(*.txt)|*.txt";
            od.Title = "Open File";
            // Show the Dialog.  
            // If the user clicked OK in the dialog and  ,
            if (od.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)od.OpenFile();
                StreamReader sr = new StreamReader(fs);
                list.Add(sr.ReadLine());
                sr.Close();
            }

            return list;
        }
    }
}
