using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audio
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Graphics graphics = pictureBox1.CreateGraphics();// создаем класс, чтоб нарисованые знаячени выводить pictureBox1
			Pen pen = new Pen(Color.Black, 3f);// цвет линий, толщина линий
			Point[] pints = new Point[1000];//массив точек

			for (int i = 0; i < pints.Length; i++)//заполняем точки 
			{
				pints[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));//задаем функию,  у = целочисленное преобразуем в double
			}
			graphics.DrawLines(pen, pints);// передаем в качестве параметра массив точек.
		}
	}
}
