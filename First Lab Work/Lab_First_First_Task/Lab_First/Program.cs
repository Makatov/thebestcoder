using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
            string line = Console.ReadLine();//создаем тип строки string line = console.readline(); string[] arr = line.Split(' ');
			string[] arr = line.Split(' ');// создаем и записываем массив через пробел
			for (int i = 0; i < arr.Length; i++)
			{
				int n = int.Parse(arr[i]);// парсим из строки в тип integer
				bool checker = true;// создаем boolean тип
				if (n == 1)
				{
					continue;
				}
				for (int j = 2; j <= Math.Sqrt(n); j++)
				{
					if (n % j == 0)
					{
						checker = false;// проверка на простое число
						break;
					}
				} 
				if (checker == true)
				{
					Console.WriteLine(n);// вывод данных
				}
			}
			Console.ReadKey();//ожидание клавиши 
		}
	}
}
