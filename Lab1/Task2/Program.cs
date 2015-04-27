using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ2014.Labs.Lab1.Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			int age;

			if (!int.TryParse(s, out age))
			{
				Console.WriteLine("Ошибка при считывании");
                Console.ReadKey();
                return;
			}

			string[] a = { "Двадцать", "Тридцать", "Сорок", "Пятьдесят","Шестьдесят" };
			string[] b = { " один", " два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять" };
			if (age < 20 || age > 69)
			{
				Console.WriteLine("Неправильный возраст. Возраст должен быть в пределах от 20 до 69 включительно");
                Console.ReadKey();
                return;
			}

			Console.Write("{0}{1} ", a[age / 10 - 2], age%10 == 0 ? "" : b[age % 10 - 1]);
			switch (age%10)
			{
				case 0: Console.WriteLine("лет"); break;
				case 1: Console.WriteLine("год"); break;
				case 2: Console.WriteLine("года"); break;
				case 3: Console.WriteLine("года"); break;
				case 4: Console.WriteLine("года"); break;
				case 5: Console.WriteLine("лет"); break;
				case 6: Console.WriteLine("лет"); break;
				case 7: Console.WriteLine("лет"); break;
				case 8: Console.WriteLine("лет"); break;
				case 9: Console.WriteLine("лет"); break;
			}

			Console.ReadKey();
		}
	}
}
