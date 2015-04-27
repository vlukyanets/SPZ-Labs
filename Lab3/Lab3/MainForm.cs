using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			GlobalData.addStudent(new Student() { Name = "Ivanov I.I.", Group = "CE-12-4" });
			GlobalData.addStudent(new Student() { Name = "Petrov P.P.", Group = "CE-12-1" });

			GlobalData.addSubject(new Subject() { Name = "Programming" });
			GlobalData.addSubject(new Subject() { Name = "Sports" });

			Student student = GlobalData.findStudent("Ivanov I.I.");
			Subject subject = GlobalData.findSubject("Sports");

			student.addSubject(subject);

			GlobalData.useStudents();
			dgview.DataSource = GlobalData.Bind;
		}

		

		private void dgview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (GlobalData.usedSubjects() && (GlobalData.Bind.Current is Subject))
			{
				var editor = new SubjectEditor(GlobalData.Bind.Current as Subject);
				editor.ShowDialog();
				if (editor.DialogResult == DialogResult.Yes)
					GlobalData.useSubjects();
			}
			else if (GlobalData.usedStudents() && (GlobalData.Bind.Current is Student))
			{
				var editor = new StudentEditor(GlobalData.Bind.Current as Student);
				editor.ShowDialog();
				if (editor.DialogResult == DialogResult.Yes)
					GlobalData.useStudents();
			}
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if (GlobalData.usedSubjects())
			{
				var editor = new SubjectEditor(null);
				editor.ShowDialog();
				if (editor.DialogResult == DialogResult.Yes)
					GlobalData.useSubjects();
			}
			else if (GlobalData.usedStudents())
			{
				var editor = new StudentEditor(null);
				editor.ShowDialog();
				if (editor.DialogResult == DialogResult.Yes)
					GlobalData.useStudents();
			}
		}

		private void resetBindings()
		{
			GlobalData.Bind.ResetBindings(true);
		}

		private void student_view_btn_Click(object sender, EventArgs e)
		{
			GlobalData.useStudents();
		}

		private void subjects_view_btn_Click(object sender, EventArgs e)
		{
			GlobalData.useSubjects();
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (GlobalData.usedSubjects())
			{
				Subject subject = GlobalData.Bind.Current as Subject;
				IEnumerable<Student> studentsWithSubject = GlobalData.Students.Where(stud => stud.Subjects.Contains(subject));
				studentsWithSubject.ToList().ForEach(stud => stud.Subjects.Remove(subject));

				GlobalData.Bind.RemoveCurrent();
				GlobalData.refreshData();
			}
			else if (GlobalData.usedStudents())
			{
				Student student = GlobalData.Bind.Current as Student;
				IEnumerable<Subject> subjectsWithStudent = GlobalData.Subjects.Where(subj => subj.Students.Contains(student));
				subjectsWithStudent.ToList().ForEach(subj => subj.Students.Remove(student));

				GlobalData.Bind.RemoveCurrent();
				GlobalData.refreshData();
			}
		}
	}
}
