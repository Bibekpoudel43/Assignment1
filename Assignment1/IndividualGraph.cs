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
    public partial class IndividualGraph : Form
    {
        List<string> _heartRate = null;
        List<string> _speed = null;
        List<string> _cadence = null;
        List<string> _altitude = null;
        List<string> _power = null;
        

        public IndividualGraph(List<string> heartRate, List<string> speed, List<string> cadence, List<string> altitude, List<string> power)
        {
            InitializeComponent();
            _heartRate = heartRate;
            _speed = speed;
            _cadence = cadence;
            _altitude = altitude;
            _power = power;
        }

        private PointPairList buildPointPairList(int[] value)
        {
            PointPairList pr = new PointPairList();
            for (int i = 0; i < value.Count(); i++)
            {
                pr.Add(i, (value[i]));
            }
            return pr;
        }
        private void plotGraph()
        {
            GraphPane myPane = zedGraphControl11.GraphPane;

            // Set the Titles
            myPane.Title = "Analysis of HeartRate";
            myPane.XAxis.Title = "Time in seconds";
            myPane.YAxis.Title = "Value";
            /* myPane.XAxis.Scale.MajorStep = 50;
             myPane.YAxis.Scale.Mag = 0;
             myPane.XAxis.Scale.Max = 1000;*/

            PointPairList heartPairList = new PointPairList();
            List<int> hr = _heartRate.Select(s => Convert.ToInt32(s)).ToList();
            heartPairList = buildPointPairList(hr.ToArray());
            LineItem heartCurve = myPane.AddCurve("HeartRate",
            heartPairList, Color.Red, SymbolType.None);
            zedGraphControl11.AxisChange();


            GraphPane myPane2 = zedGraphControl2.GraphPane;

            // Set the Titles
            myPane2.Title = "Analysis of Speed";
            myPane2.XAxis.Title = "Time in seconds";
            myPane2.YAxis.Title = "Value";
            PointPairList speedPairList = new PointPairList();
            List<int> c2 = _speed.Select(s => Convert.ToInt32(s)).ToList();
            speedPairList = buildPointPairList(c2.ToArray());
            LineItem speedCurve = myPane.AddCurve("Speed",
            speedPairList, Color.Blue, SymbolType.None);
            zedGraphControl2.AxisChange();


            GraphPane myPane3 = zedGraphControl3.GraphPane;

            // Set the Titles
            myPane3.Title = "Analysis of Cadence";
            myPane3.XAxis.Title = "Time in seconds";
            myPane3.YAxis.Title = "Value";
            PointPairList cadencePairList = new PointPairList();
            List<int> c3 = _cadence.Select(s => Convert.ToInt32(s)).ToList();
            cadencePairList = buildPointPairList(c3.ToArray());
            LineItem cadenceCurve = myPane.AddCurve("Cadence",
            cadencePairList, Color.Black, SymbolType.None);
            zedGraphControl3.AxisChange();

            GraphPane myPane4 = zedGraphControl4.GraphPane;

            // Set the Titles
            myPane4.Title = "Analysis of Power";
            myPane4.XAxis.Title = "Time in seconds";
            myPane4.YAxis.Title = "Value";
            PointPairList powerPairList = new PointPairList();
            List<int> c4 = _power.Select(s => Convert.ToInt32(s)).ToList();
            powerPairList = buildPointPairList(c4.ToArray());
            LineItem powerCurve = myPane.AddCurve("Power",
            speedPairList, Color.Cyan, SymbolType.None);
            zedGraphControl4.AxisChange();


            GraphPane myPane5 = zedGraphControl5.GraphPane;

            // Set the Titles
            myPane5.Title = "Analysis of Altitude";
            myPane5.XAxis.Title = "Time in seconds";
            myPane5.YAxis.Title = "Value";
            PointPairList altitudePairList = new PointPairList();   
            List<int> c5 = _altitude.Select(s => Convert.ToInt32(s)).ToList();
            altitudePairList = buildPointPairList(c5.ToArray());
            LineItem altitudeCurve = myPane.AddCurve("Altitude",
                  altitudePairList, Color.Crimson, SymbolType.None
                  );
            zedGraphControl.AxisChange();
        }

        private void SetSize()
        {
            zedGraphControl11.Location = new Point(0, 0);
            zedGraphControl11.IsShowPointValues = true;
            zedGraphControl11.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl2.Location = new Point(0, 0);
            zedGraphControl2.IsShowPointValues = true;
            zedGraphControl2.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl3.Location = new Point(0, 0);
            zedGraphControl3.IsShowPointValues = true;
            zedGraphControl3.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl4.Location = new Point(0, 0);
            zedGraphControl4.IsShowPointValues = true;
            zedGraphControl4.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControl5.Location = new Point(0, 0);
            zedGraphControl5.IsShowPointValues = true;
            zedGraphControl5.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
        }

        private void zedGraphControl2_Resize(object sender, EventArgs e)
        {

        }

        private void IndividualGraph_Load(object sender, EventArgs e)
        {
            plotGraph();
            SetSize();
        }

        private void IndividualGraph_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
    }
}
