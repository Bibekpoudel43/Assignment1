using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;

namespace Assignment1
{
    /// <summary>
    /// this class is created to provide the individual graph for heart, speed, cadence, power, and altitude
    /// </summary>
    public partial class IndividualGraph : Form
    {
        List<string> _heartRate = null;
        List<string> _speed = null;
        List<string> _cadence = null;
        List<string> _altitude = null;
        List<string> _power = null;

        /// <summary>
        /// constructor of this class
        /// </summary>
        /// <param name="heartRate">accepts the heartrate from wherever this class is called and initialized</param>
        /// <param name="speed">accepts the speed from wherever this class is called and initialized</param>
        /// <param name="cadence">accepts the cadence from wherever this class is called and initialized</param>
        /// <param name="altitude">accepts the altitude from wherever this class is called and initialized</param>
        /// <param name="power">accepts the power from wherever this class is called and initialized</param>
        public IndividualGraph(List<string> heartRate, List<string> speed, List<string> cadence, List<string> altitude, List<string> power)
        {
            InitializeComponent();
            _heartRate = heartRate;
            _speed = speed;
            _cadence = cadence;
            _altitude = altitude;
            _power = power;
        }

        /// <summary>
        /// this function help in assigning pointpairlist key and value
        /// </summary>
        /// <param name="value">accepts value of integer array type</param>
        /// <returns>returns the points</returns>
        private PointPairList buildPointPairList(int[] value)
        {
            PointPairList pr = new PointPairList();
            for (int i = 0; i < value.Count(); i++)
            {
                pr.Add(i, (value[i]));
            }
            return pr;
        }

        /// <summary>
        /// this function help in assigning pointpairlist key and value
        /// </summary>
        /// <param name="value">accepts value of double array type</param>
        /// <returns>returns the points</returns>
        private PointPairList buildPointPairList(double[] value)
        {
            PointPairList pr = new PointPairList();
            for (int i = 0; i < value.Count(); i++)
            {
                pr.Add(i, (value[i]));
            }
            return pr;
        }

        /// <summary>
        /// this function help in creating zedgraph based on a provided values
        /// </summary>
        private void plotGraph()
        {
            //initializing graphpane
            GraphPane myPane = zedGraphControl6.GraphPane;
            GraphPane myPane2 = zedGraphControl7.GraphPane;
            GraphPane myPane3 = zedGraphControl8.GraphPane;
            GraphPane myPane4 = zedGraphControl9.GraphPane;
            GraphPane myPane5 = zedGraphControl10.GraphPane;

            // Set the Titles
            myPane.Title= "Analysis of HeartRate";
            myPane.XAxis.Title = "Time in seconds";
            myPane.YAxis.Title = "Value";
            myPane.AxisFill.Color = Color.MintCream;
            myPane.PaneFill.Color = Color.LightGray;

            myPane2.Title = "Analysis of Speed";
            myPane2.XAxis.Title = "Time in seconds";
            myPane2.YAxis.Title = "Value";
            myPane2.AxisFill.Color = Color.MintCream;
            myPane2.PaneFill.Color = Color.LightGray;

            myPane4.Title = "Analysis of Power";
            myPane4.XAxis.Title = "Time in seconds";
            myPane4.YAxis.Title = "Value";
            myPane4.AxisFill.Color = Color.MintCream;
            myPane4.PaneFill.Color = Color.LightGray;

            myPane3.Title = "Analysis of Cadence";
            myPane3.XAxis.Title = "Time in seconds";
            myPane3.YAxis.Title = "Value";
            myPane3.AxisFill.Color = Color.MintCream;
            myPane3.PaneFill.Color = Color.LightGray;

            myPane5.Title = "Analysis of Altitude";
            myPane5.XAxis.Title = "Time in seconds";
            myPane5.YAxis.Title = "Value";
            myPane5.AxisFill.Color = Color.MintCream;
            myPane5.PaneFill.Color = Color.LightGray;

            //initializing pointparlist
            PointPairList heartPairList = new PointPairList();
            PointPairList speedPairList = new PointPairList();
            PointPairList cadencePairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();

            //setting points of a heart, sped, cadence, power and altitude 
            List<int> hr = _heartRate.Select(s => Convert.ToInt32(s)).ToList();
            heartPairList = buildPointPairList(hr.ToArray());
            List<double> c2 = _speed.Select(s => Convert.ToDouble(s)).ToList();
            speedPairList = buildPointPairList(c2.ToArray());
            List<int> c3 = _cadence.Select(s => Convert.ToInt32(s)).ToList();
            cadencePairList = buildPointPairList(c3.ToArray());
            List<int> c4 = _power.Select(s => Convert.ToInt32(s)).ToList();
            powerPairList = buildPointPairList(c4.ToArray());
            List<int> c5 = _altitude.Select(s => Convert.ToInt32(s)).ToList();
            altitudePairList = buildPointPairList(c5.ToArray());


            //ploting the line to a graph
            LineItem heartCurve = myPane.AddCurve("HeartRate",
            heartPairList, Color.Red, SymbolType.None);
            
            LineItem speedCurve = myPane2.AddCurve("Speed",
            speedPairList, Color.Blue, SymbolType.None);
           
            LineItem cadenceCurve = myPane3.AddCurve("Cadence",
            cadencePairList, Color.Black, SymbolType.None);
                     
            LineItem powerCurve = myPane4.AddCurve("Power",
            speedPairList, Color.Cyan, SymbolType.None);

            LineItem altitudeCurve = myPane5.AddCurve("Altitude",
                  altitudePairList, Color.Crimson, SymbolType.None
                  );

            zedGraphControl6.AxisChange();
            zedGraphControl7.AxisChange();
            zedGraphControl8.AxisChange();
            zedGraphControl9.AxisChange();
            zedGraphControl10.AxisChange();
        }
        /// <summary>
        /// executes when this form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IndividualGraph_Load(object sender, EventArgs e)
        {
            plotGraph();
        }
        private void zedGraphControl2_Resize(object sender, EventArgs e)
        {

        }

        private void IndividualGraph_Resize(object sender, EventArgs e)
        {
           
        }

        private void zedGraphControl4_Load(object sender, EventArgs e)
        {

        }
    }
}
