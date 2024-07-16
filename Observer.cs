using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface IGraph
        {
            void update(int i);
            double Formula(double graphValue);
            int GetID();
            void SetID(int ID);

        }

        public class Graph : Series, IGraph //крутой паттерн адаптер
        {
            public double value;
            private int ID;
            private Chart chart;
            Random rnd = new Random();
            const double k = 0.02;

            public Graph (Chart chart1)
            {
                this.chart = chart1;
            }
            public void update(int date)
            {
                this.value = this .Formula(value);
                chart.Series[this.ID].Points.AddXY(date, value);
            }
            public int GetID()
            {
                return this.ID;
            }
            public void SetID(int ID)
            {
                this.ID = ID;
            }
            public double Formula(double value)
            {
                this.value = value * (1 + k * (rnd.NextDouble() - 0.5));
                return this.value;
            }
        }

        class Publisher
        {
            public List<Graph> graphs = new List<Graph>(); //subs
            public void addGraph(Graph graph)
            {
                graphs.Add(graph);
            }
            public void removeGraph(Graph graph)
            {
                graphs.Remove(graph);
            }
            public void notify(int date)
            {
                foreach (Graph g in graphs)
                {
                    g.update(date);
                }
            }
        }

        public Graph FindByName(string name)
        {
            foreach (Graph graph in publisher.graphs)
            {
                if (graph.Name == name) return graph;
            }
            return null;
        }

        public void UpdateID(int deletedID)
        {
            foreach (Graph graph in publisher.graphs)
            {
                int currGraphID = graph.GetID();
                if (currGraphID > deletedID) graph.SetID(currGraphID - 1);
                ID--;
            }
        }
        
        int graphsNum = 0;
        int date = 1; //отсчет времени
        int ID = 0;
        public string selectedGraph;
        List<int> IDs = new List<int>();
        Publisher publisher = new Publisher();
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
            IDs.Add(newID);
            chart1.Series.Add(g);
            ID++;
            publisher.addGraph(g);
            comboDel.Items.Add(g.Name);
        }
        private void btStart_Start_Click(object sender, EventArgs e)
        {
            foreach (Graph graph in publisher.graphs)
            {
                int currID = graph.GetID();
                chart1.Series[currID].Points.Clear();
                chart1.Series[currID].Points.AddXY(0, graph.value);
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
            publisher.notify(date);
            date += 1;
        }

        private void delBt_Click(object sender, EventArgs e)
        {
            Graph deletedGraph = FindByName(selectedGraph);
            publisher.removeGraph(deletedGraph);
            comboDel.Items.Remove(deletedGraph.Name);
            chart1.Series.Remove(deletedGraph);
            int deletedGraphID = deletedGraph.GetID();
            UpdateID(deletedGraphID);
        }

        private void comboDel_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGraph = comboDel.SelectedItem.ToString();
        }

        private void noPatternBt_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }
    }
}