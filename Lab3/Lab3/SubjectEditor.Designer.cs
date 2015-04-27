namespace Lab3
{
	partial class SubjectEditor
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
			this.subjectName = new System.Windows.Forms.TextBox();
			this.name_label = new System.Windows.Forms.Label();
			this.studentGrid = new System.Windows.Forms.DataGridView();
			this.btn_apply = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// subjectName
			// 
			this.subjectName.Location = new System.Drawing.Point(56, 8);
			this.subjectName.Name = "subjectName";
			this.subjectName.Size = new System.Drawing.Size(377, 20);
			this.subjectName.TabIndex = 0;
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Location = new System.Drawing.Point(12, 11);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(38, 13);
			this.name_label.TabIndex = 1;
			this.name_label.Text = "Name:";
			// 
			// studentGrid
			// 
			this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentGrid.Location = new System.Drawing.Point(15, 34);
			this.studentGrid.Name = "studentGrid";
			this.studentGrid.ReadOnly = true;
			this.studentGrid.Size = new System.Drawing.Size(418, 119);
			this.studentGrid.TabIndex = 2;
			// 
			// btn_apply
			// 
			this.btn_apply.Location = new System.Drawing.Point(358, 159);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(75, 23);
			this.btn_apply.TabIndex = 3;
			this.btn_apply.Text = "Apply";
			this.btn_apply.UseVisualStyleBackColor = true;
			this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
			// 
			// SubjectEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 189);
			this.Controls.Add(this.btn_apply);
			this.Controls.Add(this.studentGrid);
			this.Controls.Add(this.name_label);
			this.Controls.Add(this.subjectName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "SubjectEditor";
			this.Text = "Subject Editor";
			((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox subjectName;
		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.DataGridView studentGrid;
		private System.Windows.Forms.Button btn_apply;
	}
}