using System;
namespace Lab_First_4_Task
{
    public class Circle
    {

		public double radius;
		public double area;

		public Circle()
		{
			radius = 0;
		}

		public Circle(double radius)
		{
			this.radius = radius;
			findArea();
		}

		public void findArea()
		{
			area = Math.PI * radius * radius;
		}

		public double findArea2()
		{
			return Math.PI * radius * radius;
		}

		public override string ToString()
		{
			return "radius = " + radius + "\narea = " + area;
		}


	
    }
}
