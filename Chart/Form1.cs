using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;//выводилась форма по центру
		}
		
		private int _countSecond = 0;// обновленя графика, сколько сек. пройдет чтоб обновился.
		int limitTemp = 35;
		private void Form1_Load(object sender, EventArgs e)
		{
			timer.Enabled = true;// запустить таймер

			panel1.BackColor = Color.Black;

			numeric.Minimum = 0;// чтоб не выходить за пределы
			numeric.Maximum = 40;

			// настройки оси. выводть какие - нибудь данные.
			//ChartAreas - это список графиков
			Chart.ChartAreas[0].AxisY.Minimum = -5;
			Chart.ChartAreas[0].AxisY.Maximum = 45;			
			Chart.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm:ss";// формат который будет выводится
			Chart.Series[0].XValueType = ChartValueType.DateTime;// сообщаем формат в котором будет происходить. Настраиваем мах и мин
			Chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
			Chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();// от текущего добавляем 1 мин.
			Chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
			Chart.ChartAreas[0].AxisX.Interval = 5;// конкретно сколько сек.

		}

		private void timer_Tick(object sender, EventArgs e)
		{ 
			Random random = new Random(DateTime.Now.Millisecond);//Рандомим число, чтоб графики не были одинаковами
			double ranTemp = random.Next(0, 41);//макс и мин температура.
			DateTime timeNow = DateTime.Now;//отображается на графике
			int value = Convert.ToInt32(numeric.Value);// текущее время, значение из нашего поля.
			Chart.Series[0].Points.AddXY(timeNow, value);//строим точку
			Chart.Series[1].Points.AddXY(timeNow, ranTemp);
			label.Text = ranTemp.ToString();//какое число сгеннирировалось

			_countSecond++;// наращеваем на 1 сек.

			if(_countSecond == 60)
			{
				_countSecond = 0;// обновляем таймер
				Chart.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
				Chart.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

				Chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
				Chart.ChartAreas[0].AxisX.Interval = 5;

			}
		}
	}
}
