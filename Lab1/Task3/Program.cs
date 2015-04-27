using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ2014.Labs.Lab1.Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');

			int[] a = new int[ss.Length];
			for (int i = 0; i < ss.Length; ++i)
				Int32.TryParse(ss[i], out a[i]);

			int[] first = new int[ss.Length];
			int[] second = new int[ss.Length];

			int firstLen = 0;
			int secondLen = 0;

			for (int i = 0; i < a.Length; ++i)
			{
				if (a[i] < 0)
					first[firstLen++] = a[i];
				else
					second[secondLen++] = a[i];
			}

			for (int i = 0; i < firstLen; ++i)
				a[i] = first[i];

			for (int i = 0; i < secondLen; ++i)
				a[i + firstLen] = second[i];

			for (int i = 0; i < a.Length; ++i)
				Console.Write("{0} ", a[i]);

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
