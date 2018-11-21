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
        Form1 f1 = new Form1();
        public SummaryGraph()
        {
            InitializeComponent();
        }

        private void SummaryGraph_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SummaryGraph_Load(object sender, EventArgs e)
        {
            plotGraph();
            SetSize();
        }
        private PointPairList buildPointPairList(int[] value)
        {
            List<string> heart = f1.heartRate;
            PointPairList pr = new PointPairList();
            int[] hr = {};
            for (int i = 0; i < value.Count(); i++)
            {
                pr.Add(i, value['i']);
            }
            return pr;
        }
        private PointPairList buildPointPairList(double[] data)
        {
            PointPairList pt = new PointPairList();

            for (int counter = 0; counter < data.Count(); counter++)
            {
                pt.Add(counter, (data[counter]));
            }
            return pt;

        }



        private void plotGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title = "Combined view of ";
            myPane.XAxis.Title = "Time in seconds";
            myPane.YAxis.Title = "Value";
            /* myPane.XAxis.Scale.MajorStep = 50;
             myPane.YAxis.Scale.Mag = 0;
             myPane.XAxis.Scale.Max = 1000;*/

            PointPairList heartPairList = new PointPairList();
            PointPairList speedPairList = new PointPairList();
            PointPairList cadencePairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();

            var c1 = f1.heartRate.Select(int.Parse);
            heartPairList = buildPointPairList(c1.ToArray());
            var c2 = f1.speed.Select(int.Parse);
            speedPairList = buildPointPairList(c2.ToArray());
            var c3 = f1.cadence.Select(int.Parse);
            cadencePairList = buildPointPairList(c3.ToArray());
            var c4 = f1.power.Select(int.Parse);
            powerPairList = buildPointPairList(c4.ToArray());
            var c5 = f1.altitude.Select(int.Parse);
            altitudePairList = buildPointPairList(c5.ToArray());

            LineItem heartCurve = myPane.AddCurve("Heart",
                   heartPairList, Color.Red, SymbolType.Triangle);

            LineItem speedCurve = myPane.AddCurve("Speed",
                  speedPairList, Color.Blue, SymbolType.Circle);

            LineItem cadenceCurve = myPane.AddCurve("Cadence",
                   cadencePairList, Color.Black, SymbolType.Star);

            LineItem powerCurve = myPane.AddCurve("Power",
                  speedPairList, Color.Cyan, SymbolType.Diamond);

            LineItem altitudeCurve = myPane.AddCurve("Altitude",
                  altitudePairList, Color.Crimson, SymbolType.XCross);

            zedGraphControl1.AxisChange();
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }

    }
}
