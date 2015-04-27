using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
	public static class GlobalData
	{
		private enum DisplayedValues
		{
			DisplayStudents,
			DisplaySubjects
		}

		private static DisplayedValues m_currentMode;

		private static BindingSource m_bind = new BindingSource();

		private static List<Subject> m_subjects = new List<Subject>();
		private static List<Student> m_students = new List<Student>();

		public static void refreshData()
		{
			m_bind.ResetBindings(true);
		}

		public static void useStudents()
		{
			m_bind.DataSource = Students;
			m_currentMode = DisplayedValues.DisplayStudents;
			refreshData();
		}

		public static void useSubjects()
		{
			m_bind.DataSource = Subjects;
			m_currentMode = DisplayedValues.DisplaySubjects;
			refreshData();
		}

		public static BindingSource Bind
		{
			get
			{
				return m_bind;
			}
			set
			{
				m_bind = value;
			}
		}

		public static IEnumerable<Subject> Subjects
		{
			get
			{
				return m_subjects.OrderBy(subj => subj.Name);
			}
			set
			{
				m_subjects = value.ToList();
			}
		}

		public static IEnumerable<Student> Students
		{
			get
			{
				return m_students.OrderBy(stud => stud.Name);
			}
			set
			{
				m_students = value.ToList();
			}
		}

		public static void addStudent(Student student)
		{
			m_students.Add(student);
		}

		public static void addSubject(Subject subject)
		{
			m_subjects.Add(subject);
		}

		public static bool usedStudents()
		{
			return m_currentMode == DisplayedValues.DisplayStudents;
		}

		public static bool usedSubjects()
		{
			return m_currentMode == DisplayedValues.DisplaySubjects;
		}

		public static Student findStudent(String name)
		{
			return m_students.Find(stud => stud.Name == name);
		}

		public static Subject findSubject(String name)
		{
			return m_subjects.Find(subj => subj.Name == name);
		}
	}
}
