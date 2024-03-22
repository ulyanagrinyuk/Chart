namespace Chart
{
	partial class Form1
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.numeric = new System.Windows.Forms.NumericUpDown();
			this.label = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Chart
			// 
			chartArea1.Name = "ChartArea1";
			this.Chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.Chart.Legends.Add(legend1);
			this.Chart.Location = new System.Drawing.Point(61, 88);
			this.Chart.Name = "Chart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Color = System.Drawing.Color.Lime;
			series1.Legend = "Legend1";
			series1.Name = "Ввод";
			series1.YValuesPerPoint = 6;
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Color = System.Drawing.Color.Red;
			series2.Legend = "Legend1";
			series2.Name = "Рандом";
			this.Chart.Series.Add(series1);
			this.Chart.Series.Add(series2);
			this.Chart.Size = new System.Drawing.Size(708, 350);
			this.Chart.TabIndex = 0;
			this.Chart.Text = "chart1";
			// 
			// numeric
			// 
			this.numeric.Location = new System.Drawing.Point(160, 35);
			this.numeric.Name = "numeric";
			this.numeric.Size = new System.Drawing.Size(120, 20);
			this.numeric.TabIndex = 1;
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(28, 35);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(31, 13);
			this.label.TabIndex = 2;
			this.label.Text = "Звук";
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(474, 18);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(72, 58);
			this.panel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(319, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(107, 70);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 47);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(57, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "ВЫКЛ";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(7, 18);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "ВКЛ";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label);
			this.Controls.Add(this.numeric);
			this.Controls.Add(this.Chart);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
		private System.Windows.Forms.NumericUpDown numeric;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}

