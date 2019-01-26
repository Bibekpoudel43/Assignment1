using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Assignment1
{
    /// <summary>
    /// this class is created to plot a summary graph for two compared file
    /// </summary>
    public partial class FileCompareSummaryGraph : Form
    {
        List<int> heart = null;
        List<double> speed = null;
        List<int> cadence = null;
        List<int> altitude = null;
        List<int> power = null;

        List<int> heart11 = null;
        List<double> speed11 = null;
        List<int> cadence11 = null;
        List<int> altitude11 = null;
        List<int> power11 = null;
        Dictionary<string, string> parameter = null;
        Dictionary<string, string> parameter1 = null;

        //initializing filecompare class file
        FileCompare fm = new FileCompare();

        /// <summary>
        /// constructor of this class
        /// </summary>
        /// <param name="heart">heart of integer data type</param>
        /// <param name="speed">speed of double data type</param>
        /// <param name="cadence">cadence of integer data type</param>
        /// <param name="altitude">altitude of integer data type</param>
        /// <param name="power">power of integer data type</param>
        /// <param name="heart11">heart of second file/integer data type </param>
        /// <param name="speed11">speed of second file/double data type</param>
        /// <param name="cadence11">cadence of second file/integer data type</param>
        /// <param name="altitude11">altitude of second file/integer data type</param>
        /// <param name="power11">power of second file/integer data type</param>
        /// <param name="parameter">contains header information of first file/string data type</param>
        /// <param name="parameter1">contains header information of second file/string data type</param>
        public FileCompareSummaryGraph(List<int> heart, 
            List<double> speed, 
            List<int> cadence, 
            List<int> altitude, 
            List<int> power, 
            List<int> heart11,
            List<double> speed11,
            List<int> cadence11,
            List<int> altitude11,
            List<int> power11,
            Dictionary<string, string> parameter,
            Dictionary<string, string> parameter1
            )
        {
            InitializeComponent();
            this.heart = heart;
            this.speed = speed;
            this.cadence = cadence;
            this.altitude = altitude;
            this.power = power;

            this.heart11 = heart11;
            this.speed11 = speed11;
            this.cadence11 = cadence11;
            this.altitude11 = altitude11;
            this.power11 = power11;
            this.parameter = parameter;
            this.parameter1 = parameter1;
        }

        /// <summary>
        /// this function help in assigning pointpairlist key and value
        /// </summary>
        /// <param name="data">accepts value of integer array type</param>
        /// <returns>returns the points</returns>
        private PointPairList buildPointPairList(int[] data)
        {
            PointPairList pt = new PointPairList();

            for (int counter = 0; counter < data.Length; counter++)
            {
                pt.Add(counter, (data[counter]));
            }
            return pt;

        }

        /// <summary>
        /// this function help in assigning pointpairlist key and value
        /// </summary>
        /// <param name="data">accepts value of double array type</param>
        /// <returns>returns the points</returns>
        private PointPairList buildPointPairList(double[] data)
        {
            PointPairList pt = new PointPairList();

            for (int counter = 0; counter < data.Length; counter++)
            {
                pt.Add(counter, (data[counter]));
            }
            return pt;

        }

        /// <summary>
        /// this function help in creating zedgraph based on a provided values
        /// </summary>
        private void plotToGraph()
        {
            //initialing graphpane
            GraphPane myPane = zedGraphControl1.GraphPane;
            // Set the Titles
            myPane.Title = "Summary Graph of First File";
            myPane.XAxis.Title = "Time in second";
            myPane.YAxis.Title = "Parameters";
            myPane.PaneFill.Color = Color.LightGray;
            myPane.AxisFill.Color = Color.MintCream;

            //initialing graphpane
            GraphPane myPane1 = zedGraphControl2.GraphPane;
            // Set the Titles
            myPane1.Title = "Summary Graph of Second File";
            myPane1.XAxis.Title = "Time in second";
            myPane1.YAxis.Title = "Parameters ";
            myPane1.PaneFill.Color = Color.LightGray;
            myPane1.AxisFill.Color = Color.MintCream;

            //initializing pointparlist
            PointPairList heartPairList = new PointPairList();
            PointPairList speedPairList = new PointPairList();
            PointPairList cadencePAirList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();

            PointPairList heartPairList1 = new PointPairList();
            PointPairList speedPairList1 = new PointPairList();
            PointPairList cadencePAirList1 = new PointPairList();
            PointPairList powerPairList1 = new PointPairList();
            PointPairList altitudePairList1 = new PointPairList();


            //setting points of a heart, speed, cadence, power and altitude
            heartPairList = buildPointPairList(heart.ToArray());
            speedPairList = buildPointPairList(speed.ToArray());
            cadencePAirList = buildPointPairList(cadence.ToArray());
            powerPairList = buildPointPairList(power.ToArray());
            altitudePairList = buildPointPairList(altitude.ToArray());

            //setting points of a heart, sped, cadence, power and altitude for second file's data
            heartPairList1 = buildPointPairList(heart11.ToArray());
            speedPairList1 = buildPointPairList(speed11.ToArray());
            cadencePAirList1 = buildPointPairList(cadence11.ToArray());
            powerPairList1 = buildPointPairList(power11.ToArray());
            altitudePairList1 = buildPointPairList(altitude11.ToArray());

            //ploting the line to a graph
            LineItem teamACurve = myPane.AddCurve("Heart Rate", heartPairList, Color.Red, SymbolType.None);
            LineItem teamACurve1 = myPane.AddCurve("Speed", speedPairList, Color.Blue, SymbolType.None);
            LineItem teamACurve2 = myPane.AddCurve("Cadence", cadencePAirList, Color.Yellow, SymbolType.None);
            LineItem teamACurve3 = myPane.AddCurve("Altitude", altitudePairList, Color.Violet, SymbolType.None);
            LineItem teamACurve4 = myPane.AddCurve("Power", powerPairList, Color.DarkCyan, SymbolType.None);


            LineItem teamACurve5 = myPane1.AddCurve("Heart Rate", heartPairList1, Color.Red, SymbolType.None);
            LineItem teamACurve6 = myPane1.AddCurve("Speed", speedPairList1, Color.Blue, SymbolType.None);
            LineItem teamACurve7 = myPane1.AddCurve("Cadence", cadencePAirList1, Color.Yellow, SymbolType.None);
            LineItem teamACurve8 = myPane1.AddCurve("Altitude", altitudePairList1, Color.Violet, SymbolType.None);
            LineItem teamACurve9 = myPane1.AddCurve("Power", powerPairList1, Color.DarkCyan, SymbolType.None);

            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();
        }

        /// <summary>
        /// sizing of zedgraph
        /// </summary>
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }

        /// <summary>
        /// sizing of zedgraph
        /// </summary>
        private void SetSize1()
        {
            zedGraphControl2.Location = new Point(0, 0);
            zedGraphControl2.IsShowPointValues = true;
            zedGraphControl2.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }

        /// <summary>
        /// initiated when form is resized
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileCompareSummaryGraph_Resize(object sender, EventArgs e)
        {
            SetSize();
            SetSize1();
        }

        /// <summary>
        /// when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileCompareSummaryGraph_Load(object sender, EventArgs e)
        {
            plotToGraph();
            summaryCalc(); summaryCalc1();
        }


        /// <summary>
        /// summary calculation of first file
        /// </summary>
        private void summaryCalc()
        {
            var maxSpeed = Summary.Max(speed);
            double averageSpeed = Summary.Average(speed);
            double avSpeed = Summary.Average(speed);
            var averageHeartRate = Summary.Average(heart);
            var maximumHeartRate = Summary.Max(heart);
            var minimumHeartRate = Summary.Min(heart);

            var totalDis = Summary.TotalDistance(avSpeed, fm.rowCount(), Int32.Parse(parameter["Interval"]));

            var averagePower = Summary.Average(power);
            var maximumPower = Summary.Max(power);

            var averageAltitude = Summary.Average(altitude);
            var maximumAltitude = Summary.Max(altitude);

            //summary of data 
            totalDistance.Text = FileCompare.roundOff(totalDis) + " Km";
            avgSpeed.Text = FileCompare.roundOff(averageSpeed) + " km/h";
            maximumSpeed.Text = FileCompare.roundOff(maxSpeed) + " km/h";
            avgHeartRate.Text = FileCompare.roundOff(averageHeartRate) + " bpm";
            maxHeartRate.Text = FileCompare.roundOff(maximumHeartRate) + " bpm";
            minHeartRate.Text = FileCompare.roundOff(minimumHeartRate) + " bpm";
            avgPower.Text = FileCompare.roundOff(averagePower) + " watts";
            maxPower.Text = FileCompare.roundOff(maximumPower) + " watts";
            avgAltitude.Text = FileCompare.roundOff(averageAltitude) + " m";

        }

        /// <summary>
        /// summary calculation of second file
        /// </summary>
        private void summaryCalc1()
        {
            var maxSpeed = Summary.Max(speed11);
            double averageSpeed = Summary.Average(speed11);
            double avSpeed = Summary.Average(speed11);
            var averageHeartRate = Summary.Average(heart11);
            var maximumHeartRate = Summary.Max(heart11);
            var minimumHeartRate = Summary.Min(heart11);

            var totalDis = Summary.TotalDistance(avSpeed, fm.rowCount1(), Int32.Parse(parameter1["Interval"]));

            var averagePower = Summary.Average(power11);
            var maximumPower = Summary.Max(power11);

            var averageAltitude = Summary.Average(altitude11);
            var maximumAltitude = Summary.Max(altitude11);

            //summary of data 
            totalDistance1.Text = FileCompare.roundOff(totalDis) + " Km";
            avgSpeed1.Text = FileCompare.roundOff(averageSpeed) + " km/h";
            maximumSpeed1.Text = FileCompare.roundOff(maxSpeed) + " km/h";
            avgHeartRate1.Text = FileCompare.roundOff(averageHeartRate) + " bpm";
            maxHeartRate1.Text = FileCompare.roundOff(maximumHeartRate) + " bpm";
            minHeartRate1.Text = FileCompare.roundOff(minimumHeartRate) + " bpm";
            avgPower1.Text = FileCompare.roundOff(averagePower) + " watts";
            maxPower1.Text = FileCompare.roundOff(maximumPower) + " watts";
            avgAltitude1.Text = FileCompare.roundOff(averageAltitude) + " m";

        }
    }
}
