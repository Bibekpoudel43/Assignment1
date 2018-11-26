using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
        private Dictionary<string, string> param = new Dictionary<string, string>();
        private List<string> paramsArrays = new List<string>();
        private int[] arrayTime = new int[] {};
        public List<string> heartRate = new List<string>();
        public List<string> speed = new List<string>();
        public List<string> speed_miles = new List<string>();
        public List<string> cadence = new List<string>();
        public List<string> altitude = new List<string>();
        public List<string> power = new List<string>();
        public List<string> powerBalancePedalling = new List<string>();
        private string[] device = new string[] { };
        int counter = 0;
        int interval = 0;
        DateTime dt = new DateTime();
        char[] findOf = { '\t', ' ', '=' };

        int cad, hrt, pwr, al;
        double sd;
            int heartCheck = 0;
            int speedCheck = 0;
            int cadenceCheck = 0;
            int altitudeCheck = 0;
            int powerCheck = 0;
            string smode = "";


        public Form1()
        {
            InitializeComponent();
            InitGrid();
            comboBox1.SelectedIndex = 0;
        }

        private void openFile(object sender, EventArgs e)
        {
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

                //reads the header file and store it in an paramaArray array
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

                try{
                    //stores header information in a dictionary with keys and values
                    for (int i = 1; i < paramsArrays.Count(); i += 2)
                    {
                        param.Add(paramsArrays[i], paramsArrays[1 + i]);
                        if (paramsArrays.Any()) //prevent IndexOutOfRangeException for empty list
                        {
                            paramsArrays.RemoveAt(paramsArrays.Count - 1);
                        }
                    }
                }
                catch(ArgumentOutOfRangeException e)
                {
                    MessageBox.Show(e.Message);
                }

                //calculates smode
                smode = param["SMode"];
                SMODE(smode);

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

                //displaying datetime
                if (param.ContainsKey("Date"))
                {
                    string dateTime = param["Date"];
                    DateTime date01 = DateTime.ParseExact(dateTime, "yyyyMMdd", CultureInfo.InvariantCulture);
                    lblDate.Text = date01.ToString("dddd, MMMM dd yyyy");
                }

                deviceName.Text = deviceN(param["Monitor"]);
               
                //displaying starttime in header
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
                if (heartCheck == 1)
                {
                    hrt = int.Parse(val[0]);
                }
               if (speedCheck == 1)
                {
                    sd = int.Parse(val[1]);
                }
                if (cadenceCheck == 1)
                {
                    cad = int.Parse(val[2]);
                }
                if (powerCheck == 1)
                {
                    pwr = int.Parse(val[4]);

                }
                if (altitudeCheck == 1)
                {
                    al = int.Parse(val[3]);
                }
                heartRate.Add(hrt.ToString());
                speed.Add((sd * 0.1).ToString());
                speed_miles.Add(roundOff(sd * 0.1 * 0.621371).ToString());
                cadence.Add(cad.ToString());
                altitude.Add(al.ToString());
                power.Add(pwr.ToString());
                powerBalancePedalling.Add(val[5]);
                val = null;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //timeinterval for each row
        public string calculateTimeInterval(string time)
        {
            // fetch the en-GB culture
            CultureInfo ukCulture = new CultureInfo("en-GB");
            dt = DateTime.ParseExact(time, "HH:mm:ss.f", ukCulture.DateTimeFormat);
            string result = dt.AddSeconds(interval).ToString("HH:mm:ss.f");
            return result;
        }

        //displayed list data to grid view table
        public void viewHrData()
        {      
            if (comboBox1.SelectedIndex == 0)
            {
                int counter = 0;
                foreach (var value in speed)
                {
                    dataGridView.Rows.Add(calculateTimeInterval(param["StartTime"])
                    , heartRate[counter]
                    , speed[counter]
                    , speed_miles[counter]
                    , cadence[counter]
                    , altitude[counter]
                    , power[counter]
                    );
                    counter++;
                    interval = interval + 1;

                }
            }
          
        }
        private void kmhMenu_Click(object sender, EventArgs e)
        {


        }

        private void mphMenu_Click(object sender, EventArgs e)
        {

        }

        //adding HRdata to dictionary 
        private void hrDataToDictionary()
        {
            hrData.Add("heartRate", heartRate);
            hrData.Add("speed", speed);
            hrData.Add("speed_miles", speed_miles);
            hrData.Add("cadence", cadence);
            hrData.Add("altitude", altitude);
            hrData.Add("power", power);
        }


        //summary calculation
        private void summaryCalc()
        {
            var maxSpeed = Summary.Max(hrData["speed"]);
            //var totalDistanceCovered = Summary.Sum(hrData["cadence"]);
            double averageSpeed = Summary.Average(hrData["speed"]);
            double avSpeed = Summary.Average(hrData["speed"]);
            var averageHeartRate = Summary.Average(hrData["heartRate"]);
            var maximumHeartRate = Summary.Max(hrData["heartRate"]);
            var minimumHeartRate = Summary.Min(hrData["heartRate"]);

            var totalDis = Summary.TotalDistance(avSpeed, dataGridView.RowCount, Int32.Parse(param["Interval"]));

            var averagePower = Summary.Average(hrData["power"]);
            var maximumPower = Summary.Max(hrData["power"]);

            var averageAltitude = Summary.Average(hrData["altitude"]);
            var maximumAltitude = Summary.Max(hrData["altitude"]);

            //summary of data 
            totalDistance.Text = roundOff(totalDis) + " Km";
            avgSpeed.Text = roundOff(averageSpeed) + " km/h";
            maximumSpeed.Text = roundOff(maxSpeed)+ " km/h";
            avgHeartRate.Text = roundOff(averageHeartRate) + " bpm";
            maxHeartRate.Text = roundOff(maximumHeartRate) + " bpm";
            minHeartRate.Text = roundOff(minimumHeartRate) + " bpm";
            avgPower.Text = roundOff(averagePower) + " watts";
            maxPower.Text =roundOff(maximumPower) + " watts";
            avgAltitude.Text =roundOff(averageAltitude) + " m";

        }


        //specifying column header
        private void InitGrid()
        {
            dataGridView.ColumnCount = 7;
            dataGridView.Columns[0].Name = "TimeInterval (HH:MM:SS)";
            dataGridView.Columns[1].Name = "Heart Rate (bpm)";
            dataGridView.Columns[2].Name = "Speed (km/h)";
            dataGridView.Columns[3].Name = "Speed (mph)";
            dataGridView.Columns[4].Name = "Cadence (rpm)";
            dataGridView.Columns[5].Name = "Altitude (m)";
            dataGridView.Columns[6].Name = "Power (watts)";
        }

        //gets the device name 
        private string deviceN(string val)
        {
            string[] device = {
                "Polar Sport Tester / Vantage XL",
                "Polar Vantage NV(VNV)",
                "Polar Accurex Plus",
                "Polar XTrainer Plus",
                "N/A",
                "Polar S520",
                "Polar Coach",
                "Polar S210",
                "Polar S410",
                "Polar S510",
                "Polar S610 / S610i",
                "Polar S710 / S710i / S720i",
                "Polar S810 / S810i",
                "N/A",
                "Polar E600",
                "N/A", "N/A", "N/A", "N/A",
                "Polar AXN500",
                "Polar AXN700",
                "Polar S625X / S725X",
                "Polar S725",
                 "N/A","N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A", "N/A",
                 "Polar CS400",
                 "Polar CS600X",
                 "Polar CS600",
                 "Polar RS400",
                 "Polar RS800",
                 "Polar RS800X"
        };
            string dName = device[Convert.ToInt16(val)];
            return dName;
        }

        //calculateing smode
        private void SMODE(string mode)
        {
            heartCheck = int.Parse(mode.Substring(0, 1));
            speedCheck = int.Parse(mode.Substring(1, 1));
            cadenceCheck = int.Parse(mode.Substring(2, 1));
            altitudeCheck = int.Parse(mode.Substring(3, 1));
            powerCheck = int.Parse(mode.Substring(4, 1));
    }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //toggleable speed (setting visible column based on toggleable comboitem)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView.Columns[2].Visible = true;
                dataGridView.Columns[3].Visible = false;
                return;
            }
            dataGridView.Columns[3].Visible = true;
            dataGridView.Columns[2].Visible = false;

        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            //instansating summarygraph variable (display in combied graph)
            SummaryGraph sm = new SummaryGraph(heartRate, speed, cadence, altitude, power);
            sm.Show();
        }

        private void btnIndividualGraph_Click(object sender, EventArgs e)
        {
            //instansating individualgraph variable (display individually)
            IndividualGraph id = new IndividualGraph(heartRate, speed, cadence, altitude, power);
            id.Show();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        //minimizing the decimal value to 2
        private static double roundOff(double val)
        {
            double data = Math.Round(val, 2, MidpointRounding.AwayFromZero);
            return data;
        }

    }
}
