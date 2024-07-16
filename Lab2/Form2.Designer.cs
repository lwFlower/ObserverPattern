namespace Lab2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDel = new System.Windows.Forms.ComboBox();
            this.delBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.courseVal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nameAdd = new System.Windows.Forms.TextBox();
            this.addBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseVal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 524);
            this.panel3.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 2;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea3.BorderColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.DarkGray;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(651, 524);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(204)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(651, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 524);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отследить курс";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.comboDel);
            this.panel4.Controls.Add(this.delBt);
            this.panel4.Location = new System.Drawing.Point(15, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 168);
            this.panel4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название валюты";
            // 
            // comboDel
            // 
            this.comboDel.AllowDrop = true;
            this.comboDel.FormattingEnabled = true;
            this.comboDel.Location = new System.Drawing.Point(13, 29);
            this.comboDel.Name = "comboDel";
            this.comboDel.Size = new System.Drawing.Size(154, 24);
            this.comboDel.TabIndex = 11;
            this.comboDel.SelectedIndexChanged += new System.EventHandler(this.comboDel_SelectedIndexChanged);
            // 
            // delBt
            // 
            this.delBt.BackColor = System.Drawing.Color.DarkViolet;
            this.delBt.Location = new System.Drawing.Point(23, 91);
            this.delBt.Name = "delBt";
            this.delBt.Size = new System.Drawing.Size(131, 35);
            this.delBt.TabIndex = 10;
            this.delBt.Text = "Удалить валюту";
            this.delBt.UseVisualStyleBackColor = false;
            this.delBt.Click += new System.EventHandler(this.delBt_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.courseVal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.nameAdd);
            this.panel2.Controls.Add(this.addBt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 178);
            this.panel2.TabIndex = 7;
            // 
            // courseVal
            // 
            this.courseVal.DecimalPlaces = 2;
            this.courseVal.Location = new System.Drawing.Point(39, 81);
            this.courseVal.Name = "courseVal";
            this.courseVal.Size = new System.Drawing.Size(102, 22);
            this.courseVal.TabIndex = 9;
            this.courseVal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Нынешний курс";
            // 
            // nameAdd
            // 
            this.nameAdd.Location = new System.Drawing.Point(13, 28);
            this.nameAdd.Name = "nameAdd";
            this.nameAdd.Size = new System.Drawing.Size(154, 22);
            this.nameAdd.TabIndex = 7;
            // 
            // addBt
            // 
            this.addBt.BackColor = System.Drawing.Color.DarkViolet;
            this.addBt.Location = new System.Drawing.Point(23, 124);
            this.addBt.Name = "addBt";
            this.addBt.Size = new System.Drawing.Size(131, 35);
            this.addBt.TabIndex = 5;
            this.addBt.Text = "Добавить валюту";
            this.addBt.UseVisualStyleBackColor = false;
            this.addBt.Click += new System.EventHandler(this.addBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название валюты";
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.DarkViolet;
            this.btStart.Location = new System.Drawing.Point(39, 439);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(131, 35);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start/Stop";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 524);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Биржа жены Макса Максбетова";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseVal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDel;
        private System.Windows.Forms.Button delBt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown courseVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameAdd;
        private System.Windows.Forms.Button addBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer1;
    }
}