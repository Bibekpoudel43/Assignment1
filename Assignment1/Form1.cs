using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
        private Dictionary<string, string> param = new Dictionary<string, string>();
        public List<string> paramsArrays = new List<string>();
        public List<string> heartRate = new List<string>();
        public List<string> speed = new List<string>();
        public List<string> cadence = new List<string>();
        public List<string> altitude = new List<string>();
        public List<string> power = new List<string>();
        public List<string> powerBalancePedalling = new List<string>();
        int counter = 0;
        char[] findOf = { '\t', ' ', '=' };


        public Form1()
        {
            InitializeComponent();
            InitGrid();
        }

        private void openFile(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            ReadFromFile();
            viewHrData();
            summaryCalc();
        }


        //read the text from  file
        public void ReadFromFile()
        {
            string line = "";
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "HRM|*.hrm|Text Document|*.txt";
            od.Title = "Open File";
            // Show the Dialog.  
            // If the user clicked OK in the dialog then  ,
            if (od.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = (FileStream)od.OpenFile();
                StreamReader sr = new StreamReader(fs);

                while (!(line = sr.ReadLine()).Contains("[Note]"))

                {
                    counter++;

                    string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                    List<string> val = newline.Split(' ').ToList();

                    for (int i = 0; i < val.Count(); i++)
                    {
                        paramsArrays.Add(val[i]);
                    }

                }
                try {
                    for (int i = 1; i < paramsArrays.Count(); i += 2)
                    {
                        param.Add(paramsArrays[i], paramsArrays[1 + i]);
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            //add specific type data to array 
                            sortDataIntoArray(line);
                        }
                    }
                }

                //adding hr data to dictionary for easy access
                hrDataToDictionary();


                if (param.ContainsKey("Date"))
                {
                    string dateTime = param["Date"];
                    DateTime date01 = DateTime.ParseExact(dateTime, "yyyyMMdd", CultureInfo.InvariantCulture);
                    lblDate.Text = date01.ToString("dddd, MMMM dd yyyy");
                }
                if (param.ContainsKey("StartTime"))
                {
                    string time = param["StartTime"];
                    lblStartTime.Text = time;
                }
                if (param.ContainsKey("Interval"))
                {
                    string intval = param["Interval"];
                    lblInterval.Text = intval;
                }


            }
        }

        //split data and adding into list array
        public void sortDataIntoArray(string line)
        {
            try
            {

                string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                List<string> val = newline.Split(' ').ToList();
                heartRate.Add(val[0]);
                speed.Add(val[1]);
                cadence.Add(val[2]);
                altitude.Add(val[3]);
                power.Add(val[4]);
                powerBalancePedalling.Add(val[5]);
                val = null;

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //displayed list data to grid view table
        public void viewHrData()
        {

            int counter = 0;
            foreach (var value in speed)
            {
                dataGridView.Rows.Add(heartRate[counter]
                    , speed[counter]
                    , cadence[counter]
                    , altitude[counter]
                    , power[counter]);
                counter++;
            }            
        }

        //adding HRdata to dictionary 
        private void hrDataToDictionary()
        {
            hrData.Add("heartRate", heartRate);
            hrData.Add("speed", speed);
            hrData.Add("cadence", cadence);
            hrData.Add("altitude", altitude);
            hrData.Add("power", power);
        }


        //summary calculation
        private void summaryCalc()
        {
            var maxSpeed = Summary.Max(hrData["speed"]);
            //var totalDistanceCovered = Summary.Sum(hrData["cadence"]);
            var averageSpeed =  Summary.Average(hrData["speed"]);
            var averageHeartRate = Summary.Average(hrData["heartRate"]);
            var maximumHeartRate = Summary.Max(hrData["heartRate"]);
            var minimumHeartRate = Summary.Min(hrData["heartRate"]);

            var averagePower = Summary.Average(hrData["power"]);
            var maximumPower = Summary.Max(hrData["power"]);

            var averageAltitude = Summary.Average(hrData["altitude"]);
            var maximumAltitude = Summary.Max(hrData["altitude"]);

            //summary of data 
            totalDistance.Text = null;
            avgSpeed.Text =  averageSpeed.ToString();
            maximumSpeed.Text = maxSpeed.ToString();
            avgHeartRate.Text = averageHeartRate.ToString();
            maxHeartRate.Text = maximumHeartRate.ToString();
            minHeartRate.Text = minimumHeartRate.ToString();
            avgPower.Text = averagePower.ToString();
            maxPower.Text = maximumPower.ToString();
            avgAltitude.Text = averageAltitude.ToString();


        }


        //specifying column header
        private void InitGrid()
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "Heart Rate (bpm)";
            dataGridView.Columns[1].Name = "Speed (km/h)";
            dataGridView.Columns[2].Name = "Cadence (rpm)";
            dataGridView.Columns[3].Name = "Altitude (m/ft)";
            dataGridView.Columns[4].Name = "Power (watts)";
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            SummaryGraph sm = new SummaryGraph(heartRate, speed, cadence, altitude, power);
            sm.Show();
        }
    }
}
