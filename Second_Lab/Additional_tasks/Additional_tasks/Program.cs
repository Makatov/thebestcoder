using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            
            string[] s = line.Split(' ');
            string[] n1 = s[0].Split('/');
            string[] n2 = s[1].Split('/');
            int a = int.Parse(n1[0]);
            int b = int.Parse(n1[1]);
            int c = int.Parse(n2[0]);
            int d = int.Parse(n2[1]);

            Complex c1 = new Complex(a, b);
            Complex c2 = new Complex(c, d);

            c1.Simplify();
            c2.Simplify();
            

            Complex sum = c1 + c2;

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
