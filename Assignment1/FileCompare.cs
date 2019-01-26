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
using ZedGraph;

namespace Assignment1
{
    public partial class FileCompare : Form
    {
        
        List<string> parametersArray = new List<string>();
        Dictionary<string, string> parameter = new Dictionary<string, string>();
        List<int> heart = new List<int>();
        List<double> speed = new List<double>();
        List<double> speed_mile = new List<double>();
        List<int> cadence = new List<int>();
        List<int> altitude = new List<int>();
        List<int> power = new List<int>();
        List<int> powerbalance = new List<int>();
        List<DateTime> dateTime = new List<DateTime>();
        List<String> summary = new List<String>();
        Dictionary<string, List<string>> hrData = new Dictionary<string, List<string>>();
       


        List<string> parametersArray1 = new List<string>();
        Dictionary<string, string> parameter1 = new Dictionary<string, string>(); 
        List<int> heart11 = new List<int>();
        List<double> speed11 = new List<double>();
        List<double> speed_mile11 = new List<double>();
        List<int> cadence11 = new List<int>();
        List<int> altitude11 = new List<int>();
        List<int> power11 = new List<int>();
        List<int> powerbalance11 = new List<int>();
        List<DateTime> dateTime1 = new List<DateTime>();
        List<String> summary1 = new List<String>();
        Dictionary<string, List<string>> hrData1 = new Dictionary<string, List<string>>();
        int countData1 = 0, countData2 = 0;


        char[] findOf = { '\t', ' ', '=' };
        DateTime dt = new DateTime();
        int heartCheck = 0;
        int speedCheck = 0;
        int cadenceCheck = 0;
        int altitudeCheck = 0;
        int powerCheck = 0;
        int counter = 0;

        int interval = 0;

        String smode = "";
        String time = "";
        String ntime = "";
        String timee = "";

        String smode1 = "";
        String time1 = "";
        String ntime1 = "";
        String timee1 = "";
        public FileCompare()
        {
            InitializeComponent();
            InitGrid();
            InitGrid1();
        }

        private void file1btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "HRM|*.hrm|HRM/Text Document|*.txt";
            if (od.ShowDialog() == DialogResult.OK)
            {
                file1txt.Text = Path.GetFullPath(od.FileName);
            }
        }

        private void file2btn_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "HRM|*.hrm|HRM/Text Document|*.txt";
            if (od.ShowDialog() == DialogResult.OK)
            {
                file2txt.Text = Path.GetFullPath(od.FileName);
            }
        }
        public void fileprocessing(string filePath)
        {
            try
            {
                Console.WriteLine(file1txt.Text);
        
                StreamReader sr = new StreamReader(filePath);
                string line = "";
                string newLine = "";

                while (!(line = sr.ReadLine()).Contains("[Note]"))
                {

                    counter++;
                    string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                    List<string> val = newline.Split(' ').ToList();

                    for (int i = 0; i < val.Count(); i++)
                    {
                        parametersArray.Add(val[i]);
                    }

                }

                try
                {
                    //stores header information in a dictionary with keys and values
                    for (int i = 1; i < parametersArray.Count(); i += 2)
                    {
                        parameter.Add(parametersArray[i], parametersArray[1 + i]);
                        if (parametersArray.Any()) //prevent IndexOutOfRangeException for empty list
                        {
                            parametersArray.RemoveAt(parametersArray.Count - 1);
                        }
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    MessageBox.Show(e.Message);
                }
                //calculates smode
                smode = parameter["SMode"];
                SMODE(smode);

                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {


                        while ((newLine = sr.ReadLine()) != null)
                        {

                            sortDataIntoArray(newLine);
                        }
                    }
                }

            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show(exc.ToString());
            }



            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            Form1 f = new Form1();
            deviceName.Text = f.deviceN(parameter["Monitor"]);

        }

        public void fileprocessing1(string filePath)
        {

            try
            {
                Console.WriteLine(file2txt.Text);

                StreamReader sr = new StreamReader(filePath);
                string line = "";
                string newLine = "";
                int counter1 = 0;

                while (!(line = sr.ReadLine()).Contains("[Note]"))
                {

                    counter1++;
                    string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                    List<string> val = newline.Split(' ').ToList();

                    for (int i = 0; i < val.Count(); i++)
                    {
                        parametersArray1.Add(val[i]);
                    }

                }

                try
                {
                    //stores header information in a dictionary with keys and values
                    for (int i = 1; i < parametersArray1.Count(); i += 2)
                    {
                        parameter1.Add(parametersArray1[i], parametersArray1[1 + i]);
                        if (parametersArray1.Any()) //prevent IndexOutOfRangeException for empty list
                        {
                            parametersArray1.RemoveAt(parametersArray1.Count - 1);
                        }
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    MessageBox.Show(e.Message);
                }
                //calculates smode
                smode = parameter1["SMode"];
                SMODE(smode);

                while (!sr.EndOfStream)
                {
                    if ((line = sr.ReadLine()).Contains("[HRData]"))
                    {


                        while ((newLine = sr.ReadLine()) != null)
                        {

                            sortDataIntoArray1(newLine);

                        }
                    }
                }

            }
            catch (InvalidOperationException exc)
            {
                MessageBox.Show(exc.ToString());
            }

            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            Form1 fm = new Form1();
            deviceName1.Text = fm.deviceN(parameter1["Monitor"]);

        }

        public void sortDataIntoArray(string line)
        {
            try
            {
                int heart11 = 0;
                int speed1 = 0, cadence1 = 0, altitude1 = 0, power1 = 0, powerbal = 0;
                string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                List<string> val = newline.Split(' ').ToList();
                if (heartCheck == 1)
                {
                    heart11 = int.Parse(val[0]);
                }
                if (speedCheck == 1)
                {
                    speed1 = int.Parse(val[1]);
                }
                if (cadenceCheck == 1)
                {
                    cadence1 = int.Parse(val[2]);
                }
                if (powerCheck == 1)
                {
                    power1 = int.Parse(val[4]);
                    powerbal = int.Parse(val[5]);

                }
                if (altitudeCheck == 1)
                {
                    altitude1 = int.Parse(val[3]);
                }

                heart.Add(heart11);
                speed.Add(speed1 * 0.1);
                speed_mile.Add(roundOff(speed1 * 0.1 * 0.621371));
                cadence.Add(cadence1);
                altitude.Add(altitude1);
                power.Add(power1);
                powerbalance.Add(powerbal);
                val = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }

        public void sortDataIntoArray1(string line)
        {
            try
            {
                int hrt = 0, sp = 0, cd = 0, al = 0, pw = 0, pwb = 0;
                string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                List<string> val = newline.Split(' ').ToList();
                if (heartCheck == 1)
                {
                    hrt = int.Parse(val[0]);
                }
                if (speedCheck == 1)
                {
                    sp = int.Parse(val[1]);
                }
                if (cadenceCheck == 1)
                {
                    cd = int.Parse(val[2]);
                }
                if (powerCheck == 1)
                {
                    pw = int.Parse(val[4]);
                    pwb = int.Parse(val[5]);

                }
                if (altitudeCheck == 1)
                {
                    al = int.Parse(val[3]);
                }

                heart11.Add(hrt);
                speed11.Add(sp * 0.1);
                speed_mile11.Add(roundOff(sp * 0.1 * 0.621371));
                cadence11.Add(cd);
                altitude11.Add(al);
                power11.Add(pw);
                powerbalance11.Add(pwb);
                val = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //minimizing the decimal value to 2
        public static double roundOff(double val)
        {
            double data = Math.Round(val, 2, MidpointRounding.AwayFromZero);
            return data;
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

        //timeinterval for each row
        public string timeBuilder(string time)
        {
            // fetch the en-GB culture
            CultureInfo ukCulture = new CultureInfo("en-GB");
            dt = DateTime.ParseExact(time, "HH:mm:ss.f", ukCulture.DateTimeFormat);
            string result = dt.AddSeconds(interval).ToString("HH:mm:ss.f");
            return result;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(file1txt.Text) && string.IsNullOrEmpty(file2txt.Text))
            {
                MessageBox.Show("Please choose the file first");
            }
            else
            {
                fileprocessing(file1txt.Text);
                FillTable1();

                fileprocessing1(file2txt.Text);
                FillTable2();
            }
        }

        private void btnSummaryGraph_Click(object sender, EventArgs e)
        {
            if (File1GridView.RowCount > 1 && File2GridView.RowCount > 1)
            {
                //instansating summarygraph variable (display in combied graph)
                FileCompareSummaryGraph sm = new FileCompareSummaryGraph(heart, speed, cadence, altitude, power, heart11, speed11, cadence11, altitude11, power11, parameter, parameter1);
                sm.Show();
            }
            else
            {
                MessageBox.Show("Please Select the File First");
            }
        }

        public void FillTable1()
        {
                int counter = 0;
                foreach (int value in heart)
                {

                    File1GridView.Rows.Add(timeBuilder(parameter["StartTime"])
                        , heart[counter]
                        , speed[counter]
                        , cadence[counter]
                        , altitude[counter]
                        , power[counter]
                        , powerbalance[counter]
                        );
                    counter++;
                    interval++;
                }
        }


        public void FillTable2()
        {
            int interval = 0;
            int counter1 = 0;
                foreach (int value in heart11)
                {
                    File2GridView.Rows.Add(timeBuilder(parameter1["StartTime"])
                     , heart11[counter1]
                     , speed11[counter1]
                     , cadence11[counter1]
                     , altitude11[counter1]
                     , power11[counter1]
                     , powerbalance11[counter1]
                     );
                    counter1++;
                    interval++;
                }

        }

        //specifying column header
        private void InitGrid()
        {
            File1GridView.ColumnCount = 7;
            File1GridView.Columns[0].Name = "TimeInterval (HH:MM:SS)";
            File1GridView.Columns[1].Name = "Heart Rate (bpm)";
            File1GridView.Columns[2].Name = "Speed (km/h)";
            File1GridView.Columns[3].Name = "Cadence (rpm)";
            File1GridView.Columns[4].Name = "Altitude (m)";
            File1GridView.Columns[5].Name = "Power (watts)";
            File1GridView.Columns[6].Name = "Power Balance";
        }

        //specifying column header
        private void InitGrid1()
        {
            File2GridView.ColumnCount =7;
            File2GridView.Columns[0].Name = "TimeInterval (HH:MM:SS)";
            File2GridView.Columns[1].Name = "Heart Rate (bpm)";
            File2GridView.Columns[2].Name = "Speed (km/h)";
            File2GridView.Columns[3].Name = "Cadence (rpm)";
            File2GridView.Columns[4].Name = "Altitude (m)";
            File2GridView.Columns[5].Name = "Power (watts)";
            File2GridView.Columns[6].Name = "Power Balance";
        }

        public int rowCount()
        {
            int count = 0;
            count = File1GridView.RowCount;
            return count;
        }

        public int rowCount1()
        {
            int count = 0;
            count = File2GridView.RowCount;
            return count;
        }


        private void File1GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (File1GridView.SelectedRows.Count == 0 || File1GridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Select a Row");
            }
            else
            {
                String[] heart = null, speed = null, cadence = null, altitude = null, power = null, powerBalance = null;

                String[] heart1 = null, speed1 = null, cadence1 = null, altitude1 = null, power1 = null, powerBalance1 = null;

                File2GridView.ClearSelection();
                File2GridView.Rows[e.RowIndex].Selected = true;

                foreach (DataGridViewRow row in File1GridView.SelectedRows)
                {
                    heart = row.Cells[1].Value.ToString().Split(' ');
                    speed = row.Cells[2].Value.ToString().Split(' ');
                    cadence = row.Cells[3].Value.ToString().Split(' ');
                    altitude = row.Cells[4].Value.ToString().Split(' ');
                    power = row.Cells[5].Value.ToString().Split(' ');
                    powerBalance = row.Cells[6].Value.ToString().Split(' ');
                }

                foreach (DataGridViewRow row in File2GridView.SelectedRows)
                {
                    heart1 = row.Cells[1].Value.ToString().Split(' ');
                    speed1 = row.Cells[2].Value.ToString().Split(' ');
                    cadence1 = row.Cells[3].Value.ToString().Split(' ');
                    altitude1 = row.Cells[4].Value.ToString().Split(' ');
                    power1 = row.Cells[5].Value.ToString().Split(' ');
                    powerBalance1 = row.Cells[6].Value.ToString().Split(' ');
                }

                double heartNum = double.Parse(heart[0]);
                double speedNum = double.Parse(speed[0]);
                double cadenceNum = double.Parse(cadence[0]);
                double altitudeNum = double.Parse(altitude[0]);
                double powerNum = double.Parse(power[0]);
                double powerbalanceNum = double.Parse(powerBalance[0]);

                double heartNum1 = double.Parse(heart1[0]);
                double speedNum1 = double.Parse(speed1[0]);
                double cadenceNum1 = double.Parse(cadence1[0]);
                double altitudeNum1 = double.Parse(altitude1[0]);
                double powerNum1 = double.Parse(power1[0]);
                double powerbalanceNum1 = double.Parse(powerBalance1[0]);

                //String header=dataGridView2=
                string env = Environment.NewLine;
                textBox1.Text = "Difference In " + env +  env +
                    "Heart Rate: " + heartNum + " - " + heartNum1 + " =  " + CalculateDifference(heartNum, heartNum1) +
                    env + "Speed: " + speedNum + " - " + speedNum1 + " =  " + CalculateDifference(speedNum, speedNum1) +
                    env + "Cadence: " + cadenceNum + " - " + cadenceNum1 + " =  " + CalculateDifference(cadenceNum, cadenceNum1) +
                    env + "Altitude: " + altitudeNum + " - " + altitudeNum1 + " =  " + CalculateDifference(altitudeNum, altitudeNum1) +
                    env + "Power: " + powerNum + " - " + powerNum1 + " =  " + CalculateDifference(powerNum, powerNum1) +
                    env + "Power Balance: " + powerbalanceNum + " - " + powerbalanceNum1 + " =  " + CalculateDifference(powerbalanceNum, powerbalanceNum1) +
                    env;

            }
        }
        //calculate difference
        public string CalculateDifference(double num1, double num2)
        {
            double rst = 0;
            rst = num1 - num2;
            return rst.ToString();
        }
    }
}
