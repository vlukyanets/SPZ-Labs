namespace Client
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
			this.components = new System.ComponentModel.Container();
			this.ipTextBox = new System.Windows.Forms.TextBox();
			this.setIpButton = new System.Windows.Forms.Button();
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			// ipTextBox
			//
			this.ipTextBox.Location = new System.Drawing.Point(12, 12);
			this.ipTextBox.Name = "ipTextBox";
			this.ipTextBox.Size = new System.Drawing.Size(242, 20);
			this.ipTextBox.TabIndex = 0;
			//
			// setIpButton
			//
			this.setIpButton.Location = new System.Drawing.Point(260, 10);
			this.setIpButton.Name = "setIpButton";
			this.setIpButton.Size = new System.Drawing.Size(75, 23);
			this.setIpButton.TabIndex = 1;
			this.setIpButton.Text = "Set IP";
			this.setIpButton.UseVisualStyleBackColor = true;
			this.setIpButton.Click += new System.EventHandler(this.setIpButton_Click);
			//
			// updateTimer
			//
			this.updateTimer.Interval = 1000;
			this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
			//
			// resultLabel
			//
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(9, 63);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(0, 13);
			this.resultLabel.TabIndex = 2;
			//
			// MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(347, 85);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.setIpButton);
			this.Controls.Add(this.ipTextBox);
			this.Name = "MainForm";
			this.Text = "Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox ipTextBox;
		private System.Windows.Forms.Button setIpButton;
		private System.Windows.Forms.Timer updateTimer;
		private System.Windows.Forms.Label resultLabel;
	}
}

