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
	public partial class StudentEditor : Form
	{
		private Student m_student;

		public StudentEditor(Student student)
		{
			InitializeComponent();

			DialogResult = DialogResult.No;

			m_student = student;

			if (m_student != null)
			{
				studentName.Text = m_student.Name;
				groupName.Text = m_student.Group;
			}

			foreach (Subject subj in GlobalData.Subjects)
			{
				if ((m_student != null) && m_student.Subjects.Contains(subj))
					selectedSubjects.Items.Add(subj);
				else
					availableSubjects.Items.Add(subj);
			}
		}

		private void apply_btn_Click(object sender, EventArgs e)
		{
			if (studentName.Text == "")
			{
				Hide();
				return;
			}

			if (m_student == null)
			{
				m_student = new Student();
				GlobalData.addStudent(m_student);
			}

			m_student.Name = studentName.Text;
			m_student.Group = groupName.Text;

			m_student.clearSubjects();
			foreach (Subject subject in selectedSubjects.Items)
				m_student.addSubject(subject);

			DialogResult = DialogResult.Yes;
			Hide();
		}

		private void select_subject_btn_Click(object sender, EventArgs e)
		{
			Subject subject = availableSubjects.SelectedItem as Subject;
			if (subject != null)
			{
				selectedSubjects.Items.Add(subject);
				availableSubjects.Items.Remove(subject);
			}
		}

		private void deselect_subject_btn_Click(object sender, EventArgs e)
		{
			Subject subject = selectedSubjects.SelectedItem as Subject;
			if (subject != null)
			{
				availableSubjects.Items.Add(subject);
				selectedSubjects.Items.Remove(subject);
			}
		}
	}
}
