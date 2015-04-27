using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ2014.Labs.Lab1.Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string s;
			s = Console.ReadLine();

			while (s.Length > 0)
			{
				string[] splittedStrings = s.Split(' ');
				if (splittedStrings.Length < 2)
					break;

				double x = Double.Parse(splittedStrings[0]);
				double y = Double.Parse(splittedStrings[1]);

				if (((x < 0 && y > x * x) || (x > 0 && y < 0)) && (x * x + y * y < 1))
					Console.WriteLine("{0} {1} - {2}", x, y, "Hit");
				else
					Console.WriteLine("{0} {1} - {2}", x, y, "Not hit");

				s = Console.ReadLine();
			}

			Console.ReadKey();
		}
	}
}
