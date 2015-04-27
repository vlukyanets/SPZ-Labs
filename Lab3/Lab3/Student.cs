using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Student : IComparable
    {
        public int CompareTo(Object obj)
        {
            Student s = obj as Student;
            return Name.CompareTo(s.Name);
        }

        public String Name { get; set; }
        public String Group { get; set; }

        private List<Subject> m_subjects = new List<Subject>();

        public List<Subject> Subjects 
        {
            get 
            {
                return m_subjects;
            }
        }

        public override String ToString()
        {
            return Name;
        }

		public String SubjectList
		{
			get
			{
				StringBuilder sb = new StringBuilder();

				for (int i = 0; i < m_subjects.Count; ++i)
				{
					if (i != 0)
						sb.Append(", ");

					sb.Append(m_subjects.ElementAt(i));
				}

				return sb.ToString();
			}
		}

        public void addSubject(Subject subject)
        {
            if (!m_subjects.Contains(subject))
                m_subjects.Add(subject);

            if (!subject.Students.Contains(this))
                subject.Students.Add(this);
        }

		public void clearSubjects()
		{
			foreach (Subject subject in Subjects)
				subject.Students.Remove(this);

			m_subjects.Clear();
		}
    }
}
