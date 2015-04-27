namespace Lab5
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
			this.FileNameBox = new System.Windows.Forms.TextBox();
			this.FileLabel = new System.Windows.Forms.Label();
			this.FileSelectBtn = new System.Windows.Forms.Button();
			this.NumberData = new System.Windows.Forms.TextBox();
			this.GenerateBtn = new System.Windows.Forms.Button();
			this.PerformBtn = new System.Windows.Forms.Button();
			this.LoadBtn = new System.Windows.Forms.Button();
			this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			//
			// FileNameBox
			//
			this.FileNameBox.Location = new System.Drawing.Point(12, 25);
			this.FileNameBox.Name = "FileNameBox";
			this.FileNameBox.ReadOnly = true;
			this.FileNameBox.Size = new System.Drawing.Size(280, 20);
			this.FileNameBox.TabIndex = 0;
			//
			// FileLabel
			//
			this.FileLabel.AutoSize = true;
			this.FileLabel.Location = new System.Drawing.Point(12, 9);
			this.FileLabel.Name = "FileLabel";
			this.FileLabel.Size = new System.Drawing.Size(26, 13);
			this.FileLabel.TabIndex = 1;
			this.FileLabel.Text = "File:";
			//
			// FileSelectBtn
			//
			this.FileSelectBtn.Location = new System.Drawing.Point(298, 23);
			this.FileSelectBtn.Name = "FileSelectBtn";
			this.FileSelectBtn.Size = new System.Drawing.Size(75, 23);
			this.FileSelectBtn.TabIndex = 2;
			this.FileSelectBtn.Text = "Select File";
			this.FileSelectBtn.UseVisualStyleBackColor = true;
			this.FileSelectBtn.Click += new System.EventHandler(this.FileSelectBtn_Click);
			//
			// NumberData
			//
			this.NumberData.Location = new System.Drawing.Point(12, 63);
			this.NumberData.Multiline = true;
			this.NumberData.Name = "NumberData";
			this.NumberData.ReadOnly = true;
			this.NumberData.Size = new System.Drawing.Size(361, 154);
			this.NumberData.TabIndex = 3;
			this.NumberData.TextChanged += new System.EventHandler(this.NumberData_TextChanged);
			//
			// GenerateBtn
			//
			this.GenerateBtn.Location = new System.Drawing.Point(12, 231);
			this.GenerateBtn.Name = "GenerateBtn";
			this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
			this.GenerateBtn.TabIndex = 4;
			this.GenerateBtn.Text = "Generate";
			this.GenerateBtn.UseVisualStyleBackColor = true;
			this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
			//
			// PerformBtn
			//
			this.PerformBtn.Location = new System.Drawing.Point(297, 231);
			this.PerformBtn.Name = "PerformBtn";
			this.PerformBtn.Size = new System.Drawing.Size(75, 23);
			this.PerformBtn.TabIndex = 5;
			this.PerformBtn.Text = "Perform";
			this.PerformBtn.UseVisualStyleBackColor = true;
			this.PerformBtn.Click += new System.EventHandler(this.PerformBtn_Click);
			//
			// LoadBtn
			//
			this.LoadBtn.Location = new System.Drawing.Point(155, 231);
			this.LoadBtn.Name = "LoadBtn";
			this.LoadBtn.Size = new System.Drawing.Size(75, 23);
			this.LoadBtn.TabIndex = 6;
			this.LoadBtn.Text = "Load";
			this.LoadBtn.UseVisualStyleBackColor = true;
			this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
			//
			// OpenFileDlg
			//
			this.OpenFileDlg.CheckFileExists = false;
			this.OpenFileDlg.CheckPathExists = false;
			//
			// MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 266);
			this.Controls.Add(this.LoadBtn);
			this.Controls.Add(this.PerformBtn);
			this.Controls.Add(this.GenerateBtn);
			this.Controls.Add(this.NumberData);
			this.Controls.Add(this.FileSelectBtn);
			this.Controls.Add(this.FileLabel);
			this.Controls.Add(this.FileNameBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Main Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FileNameBox;
		private System.Windows.Forms.Label FileLabel;
		private System.Windows.Forms.Button FileSelectBtn;
		private System.Windows.Forms.TextBox NumberData;
		private System.Windows.Forms.Button GenerateBtn;
		private System.Windows.Forms.Button PerformBtn;
		private System.Windows.Forms.Button LoadBtn;
		private System.Windows.Forms.OpenFileDialog OpenFileDlg;
	}
}

