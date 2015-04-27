namespace Lab6
{
	partial class MainForm
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
			this.panel = new System.Windows.Forms.Panel();
			this.circleBtn = new System.Windows.Forms.Button();
			this.rectBtn = new System.Windows.Forms.Button();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			//
			// panel
			//
			this.panel.Controls.Add(this.circleBtn);
			this.panel.Controls.Add(this.rectBtn);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(646, 333);
			this.panel.TabIndex = 0;
			this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			//
			// circleBtn
			//
			this.circleBtn.Location = new System.Drawing.Point(558, 47);
			this.circleBtn.Name = "circleBtn";
			this.circleBtn.Size = new System.Drawing.Size(75, 23);
			this.circleBtn.TabIndex = 1;
			this.circleBtn.Text = "Circle";
			this.circleBtn.UseVisualStyleBackColor = true;
			this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
			//
			// rectBtn
			//
			this.rectBtn.Location = new System.Drawing.Point(559, 12);
			this.rectBtn.Name = "rectBtn";
			this.rectBtn.Size = new System.Drawing.Size(75, 23);
			this.rectBtn.TabIndex = 0;
			this.rectBtn.Text = "Rectangle";
			this.rectBtn.UseVisualStyleBackColor = true;
			this.rectBtn.Click += new System.EventHandler(this.rectBtn_Click);
			//
			// MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 333);
			this.Controls.Add(this.panel);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button circleBtn;
		private System.Windows.Forms.Button rectBtn;
	}
}

