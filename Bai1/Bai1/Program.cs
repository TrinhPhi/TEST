using System;

namespace bai7
{
	class Program
	{
		public class Phanso
		{
			int tu;
			int mau;
			public Phanso()
			{
				tu = 0;
				mau = 1;
			}
			public Phanso(int x)
			{
				tu = x;
				mau = 1;
			}
			public Phanso(int x, int y)
			{
				tu = x;
				mau = y;
			}
			public Phanso(Phanso ob)
			{
				tu = ob.tu;
				mau = ob.mau;
			}
			public void Show()
			{
				Console.WriteLine("Phan so la: {0}/{1}", tu, mau);
			}
		}
		static void Main(string[] args)
		{
			Phanso ob1 = new Phanso(2, 5);
			ob1.Show();
			Phanso ob2 = new Phanso(ob1);
			ob2.Show();
			Console.ReadLine();
		}
	}
}