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
        public int[] arrayTime = new int[] {};
        public List<string> heartRate = new List<string>();
        public List<string> speed = new List<string>();
        public List<string> speed_miles = new List<string>();
        public List<string> cadence = new List<string>();
        public List<string> altitude = new List<string>();
        public List<string> power = new List<string>();
        public List<string> powerBalancePedalling = new List<string>();
        public string[] device = new string[] { };
        public string[] unit = { "km/h", "mph" };
        int counter = 0;
        int interval = 0;
        DateTime dt = new DateTime();
        char[] findOf = { '\t', ' ', '=' };

        int cad, hrt, pwr, al;
        double sd;
             int heartCheck =0;
            int speedCheck = 0;
            int cadenceCheck = 0;
            int altitudeCheck = 0;
            int powerCheck = 0;
            string smode = "";


        public Form1()
        {
            InitializeComponent();
            InitGrid();
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

                for (int i = 1; i < paramsArrays.Count(); i += 2)
                    {
                        param.Add(paramsArrays[i], paramsArrays[1 + i]);
                        if (paramsArrays.Any()) //prevent IndexOutOfRangeException for empty list
                        {
                            paramsArrays.RemoveAt(paramsArrays.Count - 1);
                        }
                    }

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


                if (param.ContainsKey("Date"))
                {
                    string dateTime = param["Date"];
                    DateTime date01 = DateTime.ParseExact(dateTime, "yyyyMMdd", CultureInfo.InvariantCulture);
                    lblDate.Text = date01.ToString("dddd, MMMM dd yyyy");
                }

                deviceName.Text = deviceN(param["Monitor"]);
               
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
                speed_miles.Add((sd * 0.1 * 0.621371).ToString());
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

        public string calculateTimeInterval(string time)
        {
            // fetch the en-GB culture
            CultureInfo ukCulture = new CultureInfo("en-GB");
            dt = DateTime.ParseExact(time, "HH:mm:ss", ukCulture.DateTimeFormat);
            string result = dt.AddSeconds(interval).ToString("HH:mm:ss");
            return result;
        }

        //displayed list data to grid view table
        public void viewHrData()
        {
            if ( kmhMenu.Checked == true)
            {
                int counter = 0;
                foreach (var value in speed)
                {
                    dataGridView.Rows.Add(calculateTimeInterval(param["StartTime"])
                    , heartRate[counter]
                    , speed[counter]
                    , cadence[counter]
                    , altitude[counter]
                    , power[counter]
                    );
                    counter++;
                    interval = interval + 1;

                }
            }
            else if(mphMenu.Checked == true)
            {
                int counter = 0;
                foreach (var value in speed)
                {
                    dataGridView.Rows.Add(calculateTimeInterval(param["StartTime"])
                    , heartRate[counter]
                    , speed_miles[counter]
                    , cadence[counter]
                    , altitude[counter]
                    , power[counter]
                    );
                    counter++;
                    interval = interval + 1;

                }
            }
            else
            {
                int counter = 0;
                foreach (var value in speed)
                {
                    double spd = Convert.ToDouble(speed[counter]) * 0.1;
                    dataGridView.Rows.Add(calculateTimeInterval(param["StartTime"])
                    , heartRate[counter]
                    , spd
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
            dataGridView.ColumnCount = 6;
            dataGridView.Columns[0].Name = "Time (HH:MM:SS)";
            dataGridView.Columns[1].Name = "Heart Rate (bpm)";
            dataGridView.Columns[2].Name = "Speed (km/h)";
            dataGridView.Columns[3].Name = "Cadence (rpm)";
            dataGridView.Columns[4].Name = "Altitude (m/ft)";
            dataGridView.Columns[5].Name = "Power (watts)";
        }

        private string deviceN(string val)
        {
            string[] device = {
                "Polar Sport Tester / Vantage XL",
                "Polar Vantage NV(VNV)",                "Polar Accurex Plus",                "Polar XTrainer Plus",                "N/A",                "Polar S520",                "Polar Coach",
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

        private void arrayNuller()
        {
          hrData = new Dictionary<string, List<string>>();
          param = new Dictionary<string, string>();
         paramsArrays = new List<string>();
            arrayTime =new int[]{};
            heartRate = new List<string>();
         speed = new List<string>();
         cadence = new List<string>();
         altitude = new List<string>();
         power = new List<string>();
         powerBalancePedalling = new List<string>();
         device = new string[] { };
        counter = 0;
        interval = 0;
        findOf = new char[] { };
        dataGridView.DataSource = null;
        dataGridView.Rows.Clear();

        totalDistance.Text = "";
            avgSpeed.Text = "";
            maximumSpeed.Text = "";
            avgHeartRate.Text = "";
            maxHeartRate.Text = "";
            minHeartRate.Text = "";
            avgPower.Text = "";
            maxPower.Text = "";
            avgAltitude.Text = "";
            deviceName.Text = "";
            lblStartTime.Text = "";
            lblInterval.Text = "";
            }

        private void SMODE(string mode)
        {
            heartCheck = int.Parse(mode.Substring(0, 1));
            speedCheck = int.Parse(mode.Substring(1, 1));
            cadenceCheck = int.Parse(mode.Substring(2, 1));
            altitudeCheck = int.Parse(mode.Substring(3, 1));
            powerCheck = int.Parse(mode.Substring(4, 1));
    }

      
        private void btnGraph_Click(object sender, EventArgs e)
        {
            SummaryGraph sm = new SummaryGraph(heartRate, speed, cadence, altitude, power);
            sm.Show();
        }

        private void btnIndividualGraph_Click(object sender, EventArgs e)
        {
            IndividualGraph id = new IndividualGraph(heartRate, speed, cadence, altitude, power);
            id.Show();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
