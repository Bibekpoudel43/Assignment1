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
    public partial class SummaryGraph : Form
    {
        List<string> _heartRate = null;
        List<string> _speed = null;
        List<string> _cadence = null;
        List<string> _altitude = null;
        List<string> _power = null;

        /// <summary>
        /// class constructor, accepts certain parameters from form1 form where it's object is initialized and created
        /// </summary>
        /// <param name="heartRate"></param>
        /// <param name="speed"></param>
        /// <param name="cadence"></param>
        /// <param name="altitude"></param>
        /// <param name="power"></param>
        public SummaryGraph(List<string> heartRate, List<string> speed, List<string> cadence, List<string> altitude, List<string> power)
        {
            InitializeComponent();
            _heartRate = heartRate;
            _speed = speed;
            _cadence = cadence;
            _altitude = altitude;
            _power = power;

        }
        /// <summary>
        /// this function fires when user resize the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SummaryGraph_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
        /// <summary>
        /// executes when the summary graph form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SummaryGraph_Load(object sender, EventArgs e)
        {
            plotGraph();
            SetSize();
        }

        /// <summary>
        /// this function helps in creating point in an axis of a zedgraph
        /// </summary>
        /// <param name="value">accepts value of integer array type</param>
        /// <returns>returns points</returns>
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
        /// this function helps in creating point in an axis of a zedgraph
        /// </summary>
        /// <param name="value">accepts value of double array type</param>
        /// <returns>returns points</returns>
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
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title = "Analysis of HeartRate, Speed, Cadence, Power, and Altitude in every second";
            myPane.XAxis.Title = "Time in seconds";
            myPane.YAxis.Title = "Value";
            myPane.AxisFill.Color = Color.MintCream;
            myPane.PaneFill.Color = Color.LightGray;

            //intializing pointpair list class
            PointPairList heartPairList = new PointPairList();
            PointPairList speedPairList = new PointPairList();
            PointPairList cadencePairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();

            //setting points of a differnt values 
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

            //adding lines to a zedgraph
            LineItem heartCurve = myPane.AddCurve("HeartRate",
                   heartPairList, Color.Red, SymbolType.None);

            LineItem speedCurve = myPane.AddCurve("Speed",
                  speedPairList, Color.Blue, SymbolType.None);

            LineItem cadenceCurve = myPane.AddCurve("Cadence",
                   cadencePairList, Color.Black, SymbolType.None);

            LineItem powerCurve = myPane.AddCurve("Power",
                  speedPairList, Color.Cyan, SymbolType.None);

            LineItem altitudeCurve = myPane.AddCurve("Altitude",
                  altitudePairList, Color.Crimson, SymbolType.None
                  );

            zedGraphControl1.AxisChange();
        }

        /// <summary>
        /// setting size of zedgraph 
        /// </summary>
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }
    }
}
