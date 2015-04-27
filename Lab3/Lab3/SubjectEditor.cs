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
	public partial class SubjectEditor : Form
	{
		private Subject m_subject;

		public SubjectEditor(Subject subject)
		{
			InitializeComponent();

			DialogResult = DialogResult.No;

			m_subject = subject;

			if (m_subject != null)
			{
				subjectName.Text = m_subject.Name;
				BindingSource bind = new BindingSource();
				bind.DataSource = GlobalData.Students.Where(stud => stud.Subjects.Contains(m_subject));
				studentGrid.DataSource = bind;
			}
		}

		private void btn_apply_Click(object sender, EventArgs e)
		{
			if (subjectName.Text == "")
			{
				Hide();
				return;
			}

			if (m_subject == null)
			{
				m_subject = new Subject();
				GlobalData.addSubject(m_subject);
			}

			m_subject.Name = subjectName.Text;

			DialogResult = DialogResult.Yes;
			Hide();
		}
	}
}
