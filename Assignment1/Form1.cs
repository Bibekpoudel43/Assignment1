using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment1
{
    /// <summary>
    /// this is a main form class
    /// </summary>
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
        public List<string>  intvTime = new List<string>();
        public List<string[]> dataFromFileOriginal = new List<string[]>();

        public List<string> chunkHeart = new List<string>();
        public List<string> chunkSpeed = new List<string>();
        public List<string> chunkSpeed_miles = new List<string>();
        public List<string> chunkCadence = new List<string>();
        public List<string> chunkAltitude = new List<string>();
        public List<string> chunkPower = new List<string>();
        public List<string> chunkPowerBalancePedalling = new List<string>();

        private string[] device = new string[] { };
        int counter = 0;
        int interval = 0;
        string time ="";
        int rowCount = 0;
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
        int chk_num = 0;
        string chunkedData = "";
        string env = Environment.NewLine;

        /// <summary>
        /// constructor for this class
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //invoking a function of this class
            InitGrid();
            //default speed is in km/hr, in combo box it is in index zero
            comboBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// executes when user open the file using a submenu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFile(object sender, EventArgs e)
        {
            //invoking functions of this class
            ReadFromFile();
            viewHrData();
            summaryCalc();
            calculateAdvancedMetrics();
        }


        /// <summary>
        /// reads the text from a file and store every line into a array
        /// header info to seperate array and hrdata to a seperate array
        /// </summary>
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
                        //adding the splitted value in an array
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

                //reads data of a file until the end of pages hit
                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            //add specific type data to an array 
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

        /// <summary>
        /// split data and adding into list array checking smode value
        /// </summary>
        /// <param name="line"></param>
        public void sortDataIntoArray(string line)
        {
            try
            {
                string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                List<string> val = newline.Split(' ').ToList();

                //adding a splitted value into a list array 
                dataFromFileOriginal.Add(newline.Split());

                //checking a smode value and adding a data into a specific array accordingly
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

                //adding a data to an specified list array
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

        /// <summary>
        /// timeinterval for each row
        /// </summary>
        /// <param name="time">accepts the time from header information</param>
        /// <returns>returns the times for each row of data</returns>
        public string calculateTimeInterval(string time)
        {
            // fetch the en-GB culture
            CultureInfo ukCulture = new CultureInfo("en-GB");
            dt = DateTime.ParseExact(time, "HH:mm:ss.f", ukCulture.DateTimeFormat);
            string result = dt.AddSeconds(interval).ToString("HH:mm:ss.f");
            return result;
        }


        /// <summary>
        /// fill the rows of data grid table 
        /// </summary>
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

        /// <summary>
        /// adding HRdata to dictionary 
        /// </summary>
        private void hrDataToDictionary()
        {
            hrData.Add("heartRate", heartRate);
            hrData.Add("speed", speed);
            hrData.Add("speed_miles", speed_miles);
            hrData.Add("cadence", cadence);
            hrData.Add("altitude", altitude);
            hrData.Add("power", power);
        }


        /// <summary>
        /// summary calculation of a entire data 
        /// </summary>
        private void summaryCalc()
        {
            var maxSpeed = Summary.Max(hrData["speed"]);
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

            //displaying summary of data 
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

        /// <summary>
        /// show calculated advanced metrices to a label
        /// </summary>
        public void calculateAdvancedMetrics()
        {
            Summary sv = new Summary(heartRate, speed, speed_miles, cadence, altitude, power, time);
            string FTP = sv.CalculateFunctionalThresholdPower();
            string Np = sv.CalculateNormalizedPower();
            string If = sv.CalculateIntensityFactor();
            string Tss = Summary.CalculateTrainingStressScore(heartRate);
            double pb = Summary.CalculatePowerBalance(power);

            ftplbl.Text = FTP + " watts";
            tsslbl.Text = Tss + "";
            iflbl.Text = If + "";
            nplbl.Text = Np + " watts";
            pblbl.Text = roundOff(pb).ToString();
        }

        /// <summary>
        /// specifying column header
        /// </summary>
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

       /// <summary>
       /// setting of device name
       /// </summary>
       /// <param name="val">accepts the unique number of a device</param>
       /// <returns>returns a device name</returns>
        public string deviceN(string val)
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

        /// <summary>
        /// calculates smode whether to show a specific column or not
        /// </summary>
        /// <param name="mode">accepts smode values from heading parameter information</param>
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

        /// <summary>
        /// toggleable speed unit(setting visible column based on toggleable comboitem)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// executes when user clicks on a view summary graph button
        /// summary graph form will be open when this button is fired
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGraph_Click(object sender, EventArgs e)
        {
            //instansating summarygraph variable (display in combied graph)
            SummaryGraph sm = new SummaryGraph(heartRate, speed, cadence, altitude, power);
            sm.Show();
        }

        /// <summary>
        /// filecompare form will be open when user clicks this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickComapreFile(object sender, EventArgs e)
        {
            FileCompare fc = new FileCompare();
            fc.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// individual graph form will be open when user clicks this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndividualGraph_Click(object sender, EventArgs e)
        {
            //instansating individualgraph variable (display individually)
            IndividualGraph id = new IndividualGraph(heartRate, speed, cadence, altitude, power);
            id.Show();
        }

        /// <summary>
        /// this function is used when user wants to chunks the data in a different level
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataCount() >= 4 && !string.IsNullOrEmpty(cmbChunk.Text))
            {
            int chunk_number = 0;
            string[] heart = heartRate.ToArray();
            int num = heart.Length;
            chunk_number = int.Parse(cmbChunk.Text);
            chk_num = int.Parse((num / chunk_number).ToString());
         
                if (chunk_number == 1)
                {
                    MessageBox.Show("First level chunking is already done. Please select more than 1 chunk");
                }
                else if (chunk_number == 2)
                {
                    btnchunk1.Enabled = true;
                    btnChunk2.Enabled = true;
                    btnChunk3.Enabled = false;
                    btnChunk4.Enabled = false;
                }
                else if (chunk_number == 3)
                {
                    btnchunk1.Enabled = true;
                    btnChunk2.Enabled = true;
                    btnChunk3.Enabled = true;
                    btnChunk4.Enabled = false;

                }
                else if (chunk_number == 4)
                {
                    btnchunk1.Enabled = true;
                    btnChunk2.Enabled = true;
                    btnChunk3.Enabled = true;
                    btnChunk4.Enabled = true;
                }
                ///invoking a funciton
                prepareArrays();
                MessageBox.Show("Chunk Prepared");
            }
            else
            {
                MessageBox.Show("Four Rows would have been Selected At least.");
            }
        }

        /// <summary>
        /// prepares an array for chunking
        /// </summary>
        public void prepareArrays()
        {
            foreach (string var in heartRate)
            {
                chunkHeart.Add(var);
            }
            foreach (string var in speed)
            {
               chunkSpeed.Add(var);
            }
            foreach (string var in speed_miles)
            {
                chunkSpeed_miles.Add(var);
            }
            foreach (string var in cadence)
            {
                chunkCadence.Add(var);
            }
            foreach (string var in altitude)
            {
                chunkAltitude.Add(var);
            }
            foreach (string var in power)
            {
                chunkPower.Add(var);
            }
            foreach (string var in powerBalancePedalling)
            {
                chunkPowerBalancePedalling.Add(var);
            }
        }

        /// <summary>
        /// excutes when chunk 1 button is clicked
        /// chunked data will be displayed on a grid table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnchunk1_Click(object sender, EventArgs e)
        {
            if(chk_num > 1)
            {
                string[] heart_array = chunkHeart.ToArray();
                string[] speed_array = chunkSpeed.ToArray();
                string[] speed_mile_array = chunkSpeed_miles.ToArray();
                string[] cadence_array = chunkCadence.ToArray();
                string[] altitude_array = chunkAltitude.ToArray();
                string[] power_array = chunkPower.ToArray();
                string[] pow_bal_array = chunkPowerBalancePedalling.ToArray();

                //setting a null value to a list array and other certain variables that is used only in this function 
                refreshVar();
                //adding a chunked data into a specific array
                for (int ctr1 = 0; ctr1 < chk_num; ctr1++)
                {
                    heartRate.Add(heart_array[ctr1]);
                    speed.Add(speed_array[ctr1]);
                    speed_miles.Add(speed_mile_array[ctr1]);
                    cadence.Add(cadence_array[ctr1]);
                    altitude.Add(altitude_array[ctr1]);
                    power.Add(power_array[ctr1]);
                    powerBalancePedalling.Add(pow_bal_array[ctr1]);
                }
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                //dispay chunked data into a data grid table
                viewHrData();
                Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
                //adding to dictionary 
                hrDataToDictionary();
                //summary of a chunked data 
                summaryCalc();
            }
            else
            {
                //when user clicks the button without chunking a data 
                MessageBox.Show("Please select chunk level");
            }
        }

        /// <summary>
        /// excutes when chunk 2 button is clicked
        /// chunked data will be displayed on a grid table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChunk2_Click(object sender, EventArgs e)
        {
            if(chk_num > 1)
            { 
                string[] heart_array = chunkHeart.ToArray();
                string[] speed_array = chunkSpeed.ToArray();
                string[] speed_mile_array = chunkSpeed_miles.ToArray();
                string[] cadence_array = chunkCadence.ToArray();
                string[] altitude_array = chunkAltitude.ToArray();
                string[] power_array = chunkPower.ToArray();
                string[] pow_bal_array = chunkPowerBalancePedalling.ToArray();

                //setting a null value to a list array and other certain variables that is used only in this function 
                refreshVar();
                int chunk2 = chk_num * 2;
                //adding a chunked data into a specific array
                for (int ctr1 = chk_num; ctr1 < chunk2; ctr1++)
                {
                    heartRate.Add(heart_array[ctr1]);
                    speed.Add(speed_array[ctr1]);
                    speed_miles.Add(speed_mile_array[ctr1]);
                    cadence.Add(cadence_array[ctr1]);
                    altitude.Add(altitude_array[ctr1]);
                    power.Add(power_array[ctr1]);
                    powerBalancePedalling.Add(pow_bal_array[ctr1]);
                }
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                //dispay chunked data into a data grid table
                viewHrData();
                Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
                //adding to dictionary 
                hrDataToDictionary();
                //summary of a chunked data 
                summaryCalc();
                 }
            else
            {
                //when user clicks the button without chunking a data 
                MessageBox.Show("Please select chunk level");
            }
        }
        /// <summary>
        /// excutes when chunk 3 button is clicked
        /// chunked data will be displayed on a grid table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChunk3_Click(object sender, EventArgs e)
        {
            if(chk_num > 1)
            { 
            string[] heart_array = chunkHeart.ToArray();
            string[] speed_array = chunkSpeed.ToArray();
            string[] speed_mile_array = chunkSpeed_miles.ToArray();
            string[] cadence_array = chunkCadence.ToArray();
            string[] altitude_array = chunkAltitude.ToArray();
            string[] power_array = chunkPower.ToArray();
            string[] pow_bal_array = chunkPowerBalancePedalling.ToArray();

            //setting a null value to a list array and other certain variables that is used only in this function 
            refreshVar();
            int chunk3 = chk_num * 3;
            //adding a chunked data into a specific array
            for (int ctr1 = chk_num*2; ctr1 < chunk3; ctr1++)
            {
                heartRate.Add(heart_array[ctr1]);
                speed.Add(speed_array[ctr1]);
                speed_miles.Add(speed_mile_array[ctr1]);
                cadence.Add(cadence_array[ctr1]);
                altitude.Add(altitude_array[ctr1]);
                power.Add(power_array[ctr1]);
                powerBalancePedalling.Add(pow_bal_array[ctr1]);
            }
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            //dispay chunked data into a data grid table
            viewHrData();
            Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
            //adding to dictionary 
            hrDataToDictionary();
            //summary of a chunked data 
            summaryCalc();
             }
            else
            {
            //when user clicks the button without chunking a data 
            MessageBox.Show("Please select chunk level");
            }
        }

        /// <summary>
        /// excutes when chunk 4 button is clicked
        /// chunked data will be displayed on a grid table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChunk4_Click(object sender, EventArgs e)
        {
            if(chk_num > 1)
            { 
            string[] heart_array = chunkHeart.ToArray();
            string[] speed_array = chunkSpeed.ToArray();
            string[] speed_mile_array = chunkSpeed_miles.ToArray();
            string[] cadence_array = chunkCadence.ToArray();
            string[] altitude_array = chunkAltitude.ToArray();
            string[] power_array = chunkPower.ToArray();
            string[] pow_bal_array = chunkPowerBalancePedalling.ToArray();

            //setting a null value to a list array and other certain variables that is used only in this function 
            refreshVar();
            int chunk4 = chk_num * 4;
            //adding a chunked data into a specific array
            for (int ctr1 = chk_num*3; ctr1 < chunk4; ctr1++)
            {
                heartRate.Add(heart_array[ctr1]);
                speed.Add(speed_array[ctr1]);
                speed_miles.Add(speed_mile_array[ctr1]);
                cadence.Add(cadence_array[ctr1]);
                altitude.Add(altitude_array[ctr1]);
                power.Add(power_array[ctr1]);
                powerBalancePedalling.Add(pow_bal_array[ctr1]);
            }
            dataGridView.Rows.Clear();
            dataGridView.Refresh();
            //dispay chunked data into a data grid table
            viewHrData();
            Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
            //adding to dictionary 
            hrDataToDictionary();
            //summary of a chunked data 
            summaryCalc();
            }
            else
            {
            //when user clicks the button without chunking a data 
            MessageBox.Show("Please select chunk level");
            }
        }

        /// <summary>
        /// this function executes when user cliks the view selected button 
        /// display only the selected row into a gri table 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count < 1 && dataGridView.SelectedColumns.Count < 6)
            {
                //when no rows is selected
                MessageBox.Show("Please select at least one row");
            }
            else
            {
                //setting a null value to a list array and other certain variables that is used only in this function 
                refreshVar();
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    string[] line = row.Cells[0].Value.ToString().Split(' ');
                    intvTime.Add(line[0]);

                    string[] line1 = row.Cells[1].Value.ToString().Split(' ');
                    heartRate.Add(line1[0]);

                    string[] line2 = row.Cells[2].Value.ToString().Split(' ');
                    speed.Add(line2[0]);

                    string[] spm = row.Cells[3].Value.ToString().Split(' ');
                    speed_miles.Add(spm[0]);

                    string[] line3 = row.Cells[4].Value.ToString().Split(' ');
                    cadence.Add(line3[0]);

                    string[] line4 = row.Cells[5].Value.ToString().Split(' ');
                    altitude.Add(line4[0]);

                    string[] line5 = row.Cells[6].Value.ToString().Split(' ');
                    power.Add(line5[0]);
                    powerBalancePedalling.Add(0.ToString());
                }
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                //dispay selected row's data into a data grid table
                viewHrData();
                Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
                //adding to dictionary 
                hrDataToDictionary();
                //summary of a selected row's data 
                summaryCalc();
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Calculates and retruns the average of the chunked data.
        /// </summary>
        /// <param name="totalData">the chunk of data whose averages should be calculated.</param>
        /// <returns>returns the averages of a chunked interval data</returns>
        private string CalculateAverageOfChunks(List<List<string[]>> totalData)
        {
            string result = "";
            int chunkCounter = 1;
            int totalChunks = totalData.Count;

            foreach (List<string[]> strList in totalData)
            {
                result += ("Average For Interval " + chunkCounter + "\n");
                // heart rate, speed, cadence, altitude, power
                double hr1 = 0;
                double sp1 = 0;
                double cd1 = 0;
                double al1 = 0;
                double p1 = 0;

                // calculating average now
                hr1 = Summary.GetAverage(strList, 0);
                sp1 = Summary.GetAverage(strList, 1);
                cd1 = Summary.GetAverage(strList, 2);
                al1 = Summary.GetAverage(strList, 3);
                p1 = Summary.GetAverage(strList, 4);

                result += "Average Heart Rate : " + roundOff(hr1) + "\n";
                result += "Average Speed : " + roundOff(sp1 * 0.1) + "\n";
                result += "Average Cadence : " + roundOff(cd1) + "\n";
                result += "Average Altitude : " + roundOff(al1) + "\n";
                result += "Average Power : " + roundOff(p1) + "\n\n\n";

                // next chunk
                chunkCounter++;
            }

            return result;
        }

        /// <summary>
        /// Break the passed data into specified number of chunks and return it as list of chunks.
        /// </summary>
        /// <param name="numberOfChunks">expected number of chunks for the data</param>
        /// <param name="data">the actual data which requires chunking</param>
        /// <returns></returns>
        private List<List<string[]>> BreakDataIntoChunks(int numberOfChunks, List<string[]> data)
        {
            int sizeOfData = data.Count;
            // this number of items will be placed in a chunk
            int splitAtEvery = sizeOfData / numberOfChunks;

            List<List<string[]>> comparisonData = new List<List<string[]>>();

            int endAt = 0;

            // iterate over number of times
            for (int i = 0; i < numberOfChunks; i++)
            {
                List<string[]> temp = new List<string[]>();

                // increase the amount of data to be retrieved from chunk
                endAt = endAt + splitAtEvery;

                for (int j = 0; j < endAt; j++)
                {
                    // get the values upto the specified index
                    temp.Add(data[j]);
                }

                // add the value to the file
                comparisonData.Add(temp);
            }

            return comparisonData;
        }

        /// <summary>
        /// this function is used when user wants to detect the interval of a cycling 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIntervalDetection_Click(object sender, EventArgs e)
        {
            //when no data is found 
            if (dataCount() == 0)
            {
                txtIntervalDetectionLabel.Text = "To detect interval you must load a file first.";
                return;
            }

            //invoking a function from a summary class
            //calculates the interval
            int intervals = Summary.DetectClearInterval(speed);

            //invoking a function of this class
            //passing a interval and total data from a file
            List<List<string[]>> totalData = BreakDataIntoChunks(intervals, dataFromFileOriginal);

            //invoking a function of this class
            //passing a total data to a function and the returned value is stored in a string
            string average = CalculateAverageOfChunks(totalData);
            chunkedData = average;

            //passing a averages to a form and invoking that form
            IntervalDetectionSummary id = new IntervalDetectionSummary(chunkedData);
            id.Show();

            //showing a interval in a textbox
            txtIntervalDetectionLabel.Text = "There were " + Convert.ToString(intervals) + " intervals during the period of cycling.";
        }

        /// <summary>
        /// minimizing the decimal value to 2
        /// </summary>
        /// <param name="val">accepts a double value</param>
        /// <returns>returns a round off value </returns>
        private static double roundOff(double val)
        {
            double data = Math.Round(val, 2, MidpointRounding.AwayFromZero);
            return data;
        }

        /// <summary>
        /// array and certain variable nuller
        /// </summary>
        public void refreshVar()
        {
            counter = 0;
            interval = 0;
            heartRate = new List<string>();
            speed = new List<string>();
            speed_miles = new List<string>();
            cadence = new List<string>();
            altitude = new List<string>();
            power = new List<string>(); ;
            powerBalancePedalling = new List<string>();
            intvTime = new List<string>();
            hrData = new Dictionary<string, List<string>>();
            heartCheck = 0;
            speedCheck = 0;
            cadenceCheck = 0;
            altitudeCheck = 0;
            powerCheck = 0;

        }

        /// <summary>
        /// counts the data in a table
        /// </summary>
        /// <returns>returns the count of total data in a grid table</returns>
        public int dataCount()
        {
            rowCount =  dataGridView.RowCount;
            return rowCount;
        }
    }
}
