
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_task
{
	class Student
	{
		public string name;
		public int age;
		public float gpa;

		public Student()
		{
			name = "Makatov";
			age = 18;
			gpa = 4;
		}

		public Student(string n, int a, float g)
		{
			name = n;
			age = a;
			gpa = g;
		}

		public override string ToString()
		{
			return name + " " + age + " " + gpa;
		}
	}

	class Program
	{
        static void Main(string[] args){
			Student s = new Student("Samat", 18, 4);
			Console.WriteLine(s);
			Console.ReadKey();
		}
	}
}
