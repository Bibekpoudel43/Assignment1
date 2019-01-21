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

        List<string> parametersArray1 = new List<string>();
        Dictionary<string, string> parameter1 = new Dictionary<string, string>(); List<string> arrays = new List<string>();
        List<string> arrays1 = new List<string>();
        List<int> heart11 = new List<int>();
        List<double> speed11 = new List<double>();
        List<double> speed_mile11 = new List<double>();
        List<int> cadence11 = new List<int>();
        List<int> altitude11 = new List<int>();
        List<int> power11 = new List<int>();
        List<int> powerbalance11 = new List<int>();
        List<DateTime> dateTime1 = new List<DateTime>();
        List<String> summary1 = new List<String>();

        char[] findOf = { '\t', ' ', '=' };
        int speed1, cadence1, altitude1, power1, powerbal;
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
                    arrays.Add(line);

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

        }

        public void fileprocessing1(string filePath)
        {

            try
            {
                Console.WriteLine(file2txt.Text);

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
                        parametersArray1.Add(val[i]);
                    }
                    arrays1.Add(line);

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

        }

        public void sortDataIntoArray(string line)
        {
            try
            {
                int heart11 = 0;
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
                int heart1 = 0;
                string newline = string.Join(" ", line.Split(findOf, StringSplitOptions.RemoveEmptyEntries));
                List<string> val = newline.Split(' ').ToList();
                if (heartCheck == 1)
                {
                    heart1 = int.Parse(val[0]);
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

                heart11.Add(heart1);
                speed11.Add(speed1 * 0.1);
                speed_mile11.Add(speed1 * 0.1 * 0.62);
                cadence11.Add(cadence1);
                altitude11.Add(altitude1);
                power11.Add(power1);
                powerbalance11.Add(powerbal);
                val = null;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //minimizing the decimal value to 2
        private static double roundOff(double val)
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
            fileprocessing(file1txt.Text);
            FilTable1();

            fileprocessing1(file2txt.Text);
            FilTable2();

            //SummaryFiller();

            //createWholeGraph();
            //CreateIndividualGraph();
        }

        public void FilTable1()
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

        public void FilTable2()
        {
                 int counter1 = 0;
                foreach (int value in heart)
                {
                    File2GridView.Rows.Add(timeBuilder(parameter["StartTime"])
                     , heart[counter]
                     , speed[counter]
                     , cadence[counter]
                     , altitude[counter]
                     , power[counter]
                     , powerbalance[counter]
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
            File1GridView.Columns[3].Name = "Speed (mph)";
            File1GridView.Columns[4].Name = "Cadence (rpm)";
            File1GridView.Columns[5].Name = "Altitude (m)";
            File1GridView.Columns[6].Name = "Power (watts)";
        }

        //specifying column header
        private void InitGrid1()
        {
            File2GridView.ColumnCount = 7;
            File2GridView.Columns[0].Name = "TimeInterval (HH:MM:SS)";
            File2GridView.Columns[1].Name = "Heart Rate (bpm)";
            File2GridView.Columns[2].Name = "Speed (km/h)";
            File2GridView.Columns[3].Name = "Speed (mph)";
            File1GridView.Columns[4].Name = "Cadence (rpm)";
            File2GridView.Columns[5].Name = "Altitude (m)";
            File2GridView.Columns[6].Name = "Power (watts)";
        }
    }
}
