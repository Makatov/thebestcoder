using System;
namespace Lab_First_Third_Task
{
    public class Rectangle
    {
        public int width;
        public int height;
        public int perimeter;
		public int area;


		public Rectangle()
		{
			width = 10;
			height = 4;
		}

		public Rectangle(int width, int height)
		{
			this.width = width;
			this.height = height;
		}
		public void solvePerimeter()
		{
			perimeter = width * 2 + height * 2;
		}
		public void solveArea()
		{
			area = width * height;
		}
		public override string ToString()
		{
			return "Perimeter = " + perimeter + "\narea = " + area;
		}
        }
    }

