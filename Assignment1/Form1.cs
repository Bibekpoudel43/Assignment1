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
        public Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();
        public List<string> heartRate = new List<string>();
        public List<string> speed = new List<string>();
        public List<string> cadence = new List<string>();
        public List<string> altitude = new List<string>();
        public List<string> power = new List<string>();
        public List<string> powerBalancePedalling = new List<string>();
        public Form1()
        {
            InitializeComponent();
            InitGrid();
        }

        private void openFile(object sender, EventArgs e)
        {
            ReadFromFile();
        }


        //read the value from the file
        //state load function
        public void ReadFromFile()
        {
            string line = "";
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "HRM|*.hrm|Text Document|*.txt";
            od.Title = "Open File";
            // Show the Dialog.  
            // If the user clicked OK in the dialog and  ,
            if (od.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)od.OpenFile();
                StreamReader sr = new StreamReader(fs);
                char[] delimiterChars = { ' ' };


                while ((line = sr.ReadLine()) != null)
                {

                    sortDataIntoArray(line);
                    int counter = 0;
                    foreach(var value in heartRate)
                    {
                        dataGridView.Rows.Add(heartRate[counter] +
                            " bpm", speed[counter] +
                            " km/hr", cadence[counter] +
                            " rpm", altitude[counter] + 
                            " m/ft", power[counter] + 
                            " watt", powerBalancePedalling[counter]);
                        counter++;
                    }
                }
            }
        }

        public void sortDataIntoArray(string line)
        {
            try
            {

                string newline = string.Join(" ", line.Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries));
                List<string> parts = newline.Split(' ').ToList();
                heartRate.Add(parts[0]);
                speed.Add(parts[1]);
                cadence.Add(parts[2]);
                altitude.Add(parts[3]);
                power.Add(parts[4]);
                powerBalancePedalling.Add(parts[5]);


                parts = null;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InitGrid()
        {
            dataGridView.ColumnCount = 4;
            dataGridView.Columns[0].Name = "Cadence";
            dataGridView.Columns[1].Name = "Altitude";
            dataGridView.Columns[2].Name = "Heart rate";
            dataGridView.Columns[3].Name = "Power in watts";

        }
    }
}
