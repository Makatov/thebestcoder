using System;

namespace PrimefromFile
{
	class Program
	{
		static void Main(string[] args)
		{
			string ans = "";
			string text = System.IO.File.ReadAllText(@"/Users/samat/Desktop/Programing_P2/Second_Lab/PrimeIn.txt");

			string[] arr = text.Split(' ');
			int sum = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				sum = int.Parse(arr[i]);
				if (sum == 1) continue;
				else
				{
					int j = 0;
					int cnt = 0;
					for (j = 2; j <= Math.Sqrt(sum); j++)
					{
						if (sum % j == 0)
						{
                            cnt = 1;
							break;
						}
					}
					if (cnt == 0)
						ans = ans + arr[i] + " ";
					cnt = 0;
				}
			}
			System.IO.File.WriteAllText(@"/Users/samat/Desktop/Programing_P2/Second_Lab/PrimeOut.txt", ans);
		}
	}
}
