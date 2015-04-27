using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class MainForm : Form
	{
		private Timer timer;
		private Point center;
		private Graphics graphics;
		private Brush brush;
		private Brush clearBrush;
		private int r = 10;

		private enum Direction
		{
			ToLeft,
			ToRight
		}

		Direction direction = Direction.ToLeft;

		public MainForm()
		{
			InitializeComponent();

			colorComboBox.Items.Add(Color.FromArgb(255, 0, 0));
			colorComboBox.Items.Add(Color.FromArgb(0, 255, 0));
			colorComboBox.Items.Add(Color.FromArgb(0, 0, 255));
			colorComboBox.Items.Add(Color.FromArgb(255, 0, 255));
			colorComboBox.Items.Add(Color.FromArgb(255, 255, 0));
			colorComboBox.Items.Add(Color.FromArgb(0, 255, 255));
			colorComboBox.Items.Add(Color.FromArgb(0, 0, 0));

			colorComboBox.SelectedIndex = 0;

			graphics = panel.CreateGraphics();

			center.X = panel.Width / 2;
			center.Y = panel.Height / 2;

			brush = new SolidBrush((Color)colorComboBox.SelectedItem);
			clearBrush = new SolidBrush(Color.White);

			panel.BackColor = Color.White;

			timer = new Timer();
			timer.Interval = 60;
			timer.Tick += timer_Tick;
			timer.Start();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			graphics.FillEllipse(clearBrush, center.X - r, center.Y - r, 2 * r, 2 * r);

			Point newCenter = center;
			switch (direction)
			{
				case Direction.ToLeft:
					newCenter.X = center.X - 5;
					if (newCenter.X > r)
						center = newCenter;
					else
						direction = Direction.ToRight;
					break;

				case Direction.ToRight:
					newCenter.X = center.X + 5;
					if (newCenter.X < panel.Width - r)
						center = newCenter;
					else
						direction = Direction.ToLeft;
					break;

				default:
					throw new Exception("Incorrect direction");
			}

			graphics.FillEllipse(brush, center.X - r, center.Y - r, 2 * r, 2 * r);
		}

		private void radiusBox_TextChanged(object sender, EventArgs e)
		{
			int newradius;
			if (int.TryParse(radiusBox.Text, out newradius))
				r = newradius;

			graphics.Clear(Color.White);
		}

		private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			brush = new SolidBrush((Color)colorComboBox.SelectedItem);
		}
	}
}
