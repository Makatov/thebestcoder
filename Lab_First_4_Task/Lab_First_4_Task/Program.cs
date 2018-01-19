using System;

namespace Lab_First_4_Task
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            double rd = double.Parse(Console.ReadLine());

            Circle c = new Circle(rd);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
