using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public class Subject : IComparable
    {
        public int CompareTo(Object obj)
        {
            Subject s = obj as Subject;
            return Name.CompareTo(s.Name);
        }

        public String Name { get; set; }

        private List<Student> m_students = new List<Student>();

        public override String ToString()
        {
            return Name;
        }

		public String StudentList
		{
			get
			{
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < m_students.Count; ++i)
				{
					if (i != 0)
						sb.Append(", ");

					sb.Append(m_students.ElementAt(i));
				}

				return sb.ToString();
			}
		}

        public List<Student> Students
        {
            get
            {
                return m_students;
            }
        }
    }
}
