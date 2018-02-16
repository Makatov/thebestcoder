using System;
namespace Additional_tasks
{
	class Complex
	{
		public int a;
		public int b;

		public Complex(int _a, int _b)
		{
			a = _a;
			b = _b;
		}
		public static int gcd(int n, int m)
		{
			while (m != n)
			{
				if (m > n)
					m = m - n;
				else
					n = n - m;
			}
			return m;
		}
		public static int lcm(int n, int m)
		{
			return m * n / gcd(m, n);
		}
		public override string ToString()
		{
			return a + "/" + b;
		}
		public static Complex operator +(Complex c1, Complex c2)
		{
			int side = lcm(c1.b, c2.b);
			Complex c = new Complex(c1.a * (side / c2.b) + c2.a * (side / c1.b), side);
			c.Simplify();
			return c;
		}
	
		public void Simplify()
		{
<<<<<<< HEAD
            int lcm = gcd(c1, c2);
            c1 /= lcm;
            c2 /= lcm;
=======
			int _a = this.a;
			int _b = this.b;
			while (_a > 0 && _b > 0)
			{
				if (_a > _b)
					_a = _a % _b;
				else
					_b = _b % _a;
			}
			int sums = _a + _b;
			a /= sums;
			b /= sums;
>>>>>>> f40541c7a05e1f1aa58478885a14c3621d39434f
		}
	}
    }
