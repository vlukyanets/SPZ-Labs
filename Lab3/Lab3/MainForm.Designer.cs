namespace Lab3
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
			this.dgview = new System.Windows.Forms.DataGridView();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.student_view_btn = new System.Windows.Forms.Button();
			this.subjects_view_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
			this.SuspendLayout();
			// 
			// dgview
			// 
			this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgview.Location = new System.Drawing.Point(12, 12);
			this.dgview.Name = "dgview";
			this.dgview.ReadOnly = true;
			this.dgview.Size = new System.Drawing.Size(541, 176);
			this.dgview.TabIndex = 0;
			this.dgview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgview_CellDoubleClick);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(12, 194);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 23);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(93, 194);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 2;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// student_view_btn
			// 
			this.student_view_btn.Location = new System.Drawing.Point(397, 194);
			this.student_view_btn.Name = "student_view_btn";
			this.student_view_btn.Size = new System.Drawing.Size(75, 23);
			this.student_view_btn.TabIndex = 3;
			this.student_view_btn.Text = "Students";
			this.student_view_btn.UseVisualStyleBackColor = true;
			this.student_view_btn.Click += new System.EventHandler(this.student_view_btn_Click);
			// 
			// subjects_view_btn
			// 
			this.subjects_view_btn.Location = new System.Drawing.Point(478, 194);
			this.subjects_view_btn.Name = "subjects_view_btn";
			this.subjects_view_btn.Size = new System.Drawing.Size(75, 23);
			this.subjects_view_btn.TabIndex = 4;
			this.subjects_view_btn.Text = "Subjects";
			this.subjects_view_btn.UseVisualStyleBackColor = true;
			this.subjects_view_btn.Click += new System.EventHandler(this.subjects_view_btn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 222);
			this.Controls.Add(this.subjects_view_btn);
			this.Controls.Add(this.student_view_btn);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.dgview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Lab 3";
			((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgview;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button student_view_btn;
		private System.Windows.Forms.Button subjects_view_btn;
	}
}

