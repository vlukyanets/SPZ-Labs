using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
	public partial class MainForm : Form
	{
		private System.Threading.Timer rectangleTimer, circleTimer;

		private Brush rectBrush, circleBrush;

		// Rectangle
		private Point rectangleCenter;
		private Point circleCenter;
		private int size = 50;

		private bool isRectangleMoving, isCircleMoving;

		private enum Direction
		{
			Front,
			Back
		};

		Direction rectangleDirection, circleDirection;

		public MainForm()
		{
			InitializeComponent();

			rectBrush = new SolidBrush(Color.Green);
			circleBrush = new SolidBrush(Color.Blue);

			rectangleCenter = new Point(panel.Width / 2, size / 2);
			circleCenter = new Point(size / 2, panel.Height / 2);

			rectangleDirection = circleDirection = Direction.Front;

			rectangleTimer = new System.Threading.Timer(RectangleTimerCallback, null, 100, 40);
			circleTimer = new System.Threading.Timer(CircleTimerCallback, null, 100, 40);

			isRectangleMoving = isCircleMoving = true;
		}

		public void RectangleTimerCallback(object state)
		{
			if (rectangleDirection == Direction.Front)
			{
				rectangleCenter.X += 2;
				if (rectangleCenter.X + size / 2 >= panel.Width - 100)
					rectangleDirection = Direction.Back;
			}
			else
			{
				rectangleCenter.X -= 2;
				if (rectangleCenter.X - size / 2 <= 0)
					rectangleDirection = Direction.Front;
			}
			panel.Invalidate();
		}

		public void CircleTimerCallback(object state)
		{
			if (circleDirection == Direction.Front)
			{
				circleCenter.Y += 2;
				if (circleCenter.Y + size / 2 >= panel.Height)
					circleDirection = Direction.Back;
			}
			else
			{
				circleCenter.Y -= 2;
				if (circleCenter.Y - size / 2 <= size)
					circleDirection = Direction.Front;
			}
			panel.Invalidate();
		}

		private void panel_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillEllipse(circleBrush, circleCenter.X - size / 2, circleCenter.Y - size / 2, size, size);
			e.Graphics.FillRectangle(rectBrush, rectangleCenter.X - size / 2, rectangleCenter.Y - size / 2, size, size);
		}

		private void rectBtn_Click(object sender, EventArgs e)
		{
			if (isRectangleMoving)
			{
				rectangleTimer.Change(0, System.Threading.Timeout.Infinite);
				isRectangleMoving = false;
			}
			else
			{
				rectangleTimer.Change(0, 40);
				isRectangleMoving = true;
			}
		}

		private void circleBtn_Click(object sender, EventArgs e)
		{
			if (isCircleMoving)
			{
				circleTimer.Change(0, System.Threading.Timeout.Infinite);
				isCircleMoving = false;
			}
			else
			{
				circleTimer.Change(0, 40);
				isCircleMoving = true;
			}
		}
	}
}
