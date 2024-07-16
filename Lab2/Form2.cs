using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 f)
        {
            InitializeComponent();
        }

        public class Graph : Series
        {
            public double value;
            private int ID;
            private Chart chart;
            Random rnd = new Random();
            const double k = 0.02;
            public Graph(Chart chart1)
            {
                this.chart = chart1;
            }
            
            public double formula(double value)
            {
                this.value = value * (1 + k * (rnd.NextDouble() - 0.5));
                return this.value;
            }
            public int GetID()
            {
                return this.ID;
            }
            public void SetID(int ID)
            {
                this.ID = ID;
            }

        }
        public Graph FindByName(string name)
        {
            foreach (Graph g in graphs)
            {
                if (g.Name == name) return g;
            }
            return null;
        }
        public void UpdateID(int deletedID)
        {
            foreach (Graph g in graphs)
            {
                int currGraphID = g.GetID();
                if (currGraphID > deletedID) g.SetID(currGraphID - 1);
                ID--;
            }
        }

        int graphsNum = 0;
        int date = 1; //отсчет времени
        int ID = 0;
        public string selectedGraph;
        List<Graph> graphs = new List<Graph>();

        private void addBt_Click(object sender, EventArgs e)
        {
            Graph g = new Graph(chart1);
            g.value = (double)courseVal.Value;
            g.Name = nameAdd.Text;
            g.BorderWidth = 2;
            g.ChartType = SeriesChartType.Line;
            g.LabelFormat = "f2";
            g.Points.AddXY(0, g.value);
            g.SetID(ID); //????
            int newID = g.GetID();
            graphs.Add(g);
            chart1.Series.Add(g);
            ID++;
            comboDel.Items.Add(g.Name);
        }
        private void btStart_Start_Click(object sender, EventArgs e)
        {
            foreach(Graph g in graphs)
            {
                int currID = g.GetID();
                chart1.Series[currID].Points.Clear();
                chart1.Series[currID].Points.AddXY(0, g.value);
            }

            timer1.Start();
            btStart.Click -= new EventHandler(btStart_Start_Click);
            btStart.Click += new EventHandler(btStart_Stop_Click);
        }
        private void btStart_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            date = 1;
            btStart.Click -= new EventHandler(btStart_Stop_Click);
            btStart.Click += new EventHandler(btStart_Start_Click);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Graph g in graphs)
            {
                int currID = g.GetID() ;
                g.formula(g.value);
                chart1.Series[currID].Points.AddXY(date, g.value);
            }
            date++;
        }

        private void delBt_Click(object sender, EventArgs e)
        {
            Graph deletedGraph = FindByName(selectedGraph);
            graphs.Remove(deletedGraph);
            comboDel.Items.Remove(deletedGraph.Name);
            chart1.Series.Remove(deletedGraph);
            int deletedGraphID = deletedGraph.GetID();
            UpdateID(deletedGraphID);
        }

        private void comboDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGraph = comboDel.SelectedItem.ToString();
        }
    }
}
