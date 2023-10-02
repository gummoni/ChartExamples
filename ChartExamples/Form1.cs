using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChartExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fastLineChartType1.SampleDataAdd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fastLineChartType1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            descriptiveStatistics1.SampleDataAdd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            descriptiveStatistics1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //最初と最後に日付を入れるコード
            var rnd = new Random(DateTime.Now.Millisecond);
            for (var cnt = 0; cnt < 20; cnt++)
            {
                var dt = new DateTime(2020, 1, 1, 0, 0, 0).AddSeconds(chart1.Series[0].Points.Count + 1);
                chart1.Series[0].Points.AddXY(dt.ToOADate(), rnd.Next(10) - 5.0);
            }


            //X軸の最小、最大値を設定
            chart1.ChartAreas[0].AxisX.Minimum = new DateTime(2020, 1, 1, 0, 0, 0).ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = new DateTime(2020, 1, 1, 0, 0, 0).AddSeconds(chart1.Series[0].Points.Count).ToOADate();
            chart1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
        }
    }
}
