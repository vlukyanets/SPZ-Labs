namespace Lab3
{
	partial class StudentEditor
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
			this.name_label = new System.Windows.Forms.Label();
			this.studentName = new System.Windows.Forms.TextBox();
			this.group_label = new System.Windows.Forms.Label();
			this.groupName = new System.Windows.Forms.TextBox();
			this.availableSubjects = new System.Windows.Forms.ListBox();
			this.selectedSubjects = new System.Windows.Forms.ListBox();
			this.available_subjects_label = new System.Windows.Forms.Label();
			this.selected_subjects_label = new System.Windows.Forms.Label();
			this.select_subject_btn = new System.Windows.Forms.Button();
			this.deselect_subject_btn = new System.Windows.Forms.Button();
			this.apply_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Location = new System.Drawing.Point(12, 15);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(38, 13);
			this.name_label.TabIndex = 0;
			this.name_label.Text = "Name:";
			// 
			// studentName
			// 
			this.studentName.Location = new System.Drawing.Point(53, 12);
			this.studentName.Name = "studentName";
			this.studentName.Size = new System.Drawing.Size(380, 20);
			this.studentName.TabIndex = 1;
			// 
			// group_label
			// 
			this.group_label.AutoSize = true;
			this.group_label.Location = new System.Drawing.Point(12, 47);
			this.group_label.Name = "group_label";
			this.group_label.Size = new System.Drawing.Size(39, 13);
			this.group_label.TabIndex = 2;
			this.group_label.Text = "Group:";
			// 
			// groupName
			// 
			this.groupName.Location = new System.Drawing.Point(57, 44);
			this.groupName.Name = "groupName";
			this.groupName.Size = new System.Drawing.Size(376, 20);
			this.groupName.TabIndex = 3;
			// 
			// availableSubjects
			// 
			this.availableSubjects.FormattingEnabled = true;
			this.availableSubjects.Location = new System.Drawing.Point(15, 93);
			this.availableSubjects.Name = "availableSubjects";
			this.availableSubjects.Size = new System.Drawing.Size(160, 173);
			this.availableSubjects.TabIndex = 4;
			// 
			// selectedSubjects
			// 
			this.selectedSubjects.FormattingEnabled = true;
			this.selectedSubjects.Location = new System.Drawing.Point(273, 93);
			this.selectedSubjects.Name = "selectedSubjects";
			this.selectedSubjects.Size = new System.Drawing.Size(160, 173);
			this.selectedSubjects.TabIndex = 5;
			// 
			// available_subjects_label
			// 
			this.available_subjects_label.AutoSize = true;
			this.available_subjects_label.Location = new System.Drawing.Point(12, 77);
			this.available_subjects_label.Name = "available_subjects_label";
			this.available_subjects_label.Size = new System.Drawing.Size(97, 13);
			this.available_subjects_label.TabIndex = 6;
			this.available_subjects_label.Text = "Available Subjects:";
			// 
			// selected_subjects_label
			// 
			this.selected_subjects_label.AutoSize = true;
			this.selected_subjects_label.Location = new System.Drawing.Point(270, 77);
			this.selected_subjects_label.Name = "selected_subjects_label";
			this.selected_subjects_label.Size = new System.Drawing.Size(96, 13);
			this.selected_subjects_label.TabIndex = 7;
			this.selected_subjects_label.Text = "Selected Subjects:";
			// 
			// select_subject_btn
			// 
			this.select_subject_btn.Location = new System.Drawing.Point(216, 133);
			this.select_subject_btn.Name = "select_subject_btn";
			this.select_subject_btn.Size = new System.Drawing.Size(28, 28);
			this.select_subject_btn.TabIndex = 8;
			this.select_subject_btn.Text = "->";
			this.select_subject_btn.UseVisualStyleBackColor = true;
			this.select_subject_btn.Click += new System.EventHandler(this.select_subject_btn_Click);
			// 
			// deselect_subject_btn
			// 
			this.deselect_subject_btn.Location = new System.Drawing.Point(216, 186);
			this.deselect_subject_btn.Name = "deselect_subject_btn";
			this.deselect_subject_btn.Size = new System.Drawing.Size(28, 28);
			this.deselect_subject_btn.TabIndex = 9;
			this.deselect_subject_btn.Text = "<-";
			this.deselect_subject_btn.UseVisualStyleBackColor = true;
			this.deselect_subject_btn.Click += new System.EventHandler(this.deselect_subject_btn_Click);
			// 
			// apply_btn
			// 
			this.apply_btn.Location = new System.Drawing.Point(358, 275);
			this.apply_btn.Name = "apply_btn";
			this.apply_btn.Size = new System.Drawing.Size(75, 23);
			this.apply_btn.TabIndex = 10;
			this.apply_btn.Text = "Apply";
			this.apply_btn.UseVisualStyleBackColor = true;
			this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
			// 
			// StudentEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 310);
			this.Controls.Add(this.apply_btn);
			this.Controls.Add(this.deselect_subject_btn);
			this.Controls.Add(this.select_subject_btn);
			this.Controls.Add(this.selected_subjects_label);
			this.Controls.Add(this.available_subjects_label);
			this.Controls.Add(this.selectedSubjects);
			this.Controls.Add(this.availableSubjects);
			this.Controls.Add(this.groupName);
			this.Controls.Add(this.group_label);
			this.Controls.Add(this.studentName);
			this.Controls.Add(this.name_label);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "StudentEditor";
			this.Text = "Student Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label name_label;
		private System.Windows.Forms.TextBox studentName;
		private System.Windows.Forms.Label group_label;
		private System.Windows.Forms.TextBox groupName;
		private System.Windows.Forms.ListBox availableSubjects;
		private System.Windows.Forms.ListBox selectedSubjects;
		private System.Windows.Forms.Label available_subjects_label;
		private System.Windows.Forms.Label selected_subjects_label;
		private System.Windows.Forms.Button select_subject_btn;
		private System.Windows.Forms.Button deselect_subject_btn;
		private System.Windows.Forms.Button apply_btn;
	}
}