using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.02;
        Random rnd = new Random();
        double dollar;
        double euro;
        int i = 1;
        private void btStart_Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            chart1.Series[0].Points.AddXY(0, dollar);
            chart1.Series[1].Points.AddXY(0, euro);
            timer1.Start();
            btStart.Click -= new EventHandler(btStart_Start_Click);
            btStart.Click += new EventHandler(btStart_Stop_Click);
        }
        private void btStart_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            i = 1;
            btStart.Click -= new EventHandler(btStart_Stop_Click);
            btStart.Click += new EventHandler(btStart_Start_Click);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                dollar = dollar * (1 + k * (rnd.NextDouble() - 0.5));
                chart1.Series[0].Points.AddXY(i, dollar);
                euro = euro * (1 + k * (rnd.NextDouble() - 0.5));
                chart1.Series[1].Points.AddXY(i, euro);
                i += 1;
        }

        
    }
}