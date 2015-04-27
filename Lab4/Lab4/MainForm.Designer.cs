namespace Lab4
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
			this.radiusBox = new System.Windows.Forms.TextBox();
			this.colorComboBox = new System.Windows.Forms.ComboBox();
			this.panel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// radiusBox
			// 
			this.radiusBox.Location = new System.Drawing.Point(12, 12);
			this.radiusBox.Name = "radiusBox";
			this.radiusBox.Size = new System.Drawing.Size(111, 20);
			this.radiusBox.TabIndex = 0;
			this.radiusBox.Text = "10";
			this.radiusBox.TextChanged += new System.EventHandler(this.radiusBox_TextChanged);
			// 
			// colorComboBox
			// 
			this.colorComboBox.FormattingEnabled = true;
			this.colorComboBox.Location = new System.Drawing.Point(422, 12);
			this.colorComboBox.Name = "colorComboBox";
			this.colorComboBox.Size = new System.Drawing.Size(121, 21);
			this.colorComboBox.TabIndex = 1;
			this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(12, 38);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(531, 285);
			this.panel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 335);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.colorComboBox);
			this.Controls.Add(this.radiusBox);
			this.Name = "MainForm";
			this.Text = "Lab 4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox radiusBox;
		private System.Windows.Forms.ComboBox colorComboBox;
		private System.Windows.Forms.Panel panel;
	}
}

