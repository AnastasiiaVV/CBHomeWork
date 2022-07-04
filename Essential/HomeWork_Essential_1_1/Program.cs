using System;

namespace HomeWork_Essential_1_1
{
	class Program
	{
		static void Main(string[] args) {
			Console.Write("Введите первую длину стороны: ");
			double side1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите вторую длину стороны: ");
			double side2 = Convert.ToDouble(Console.ReadLine());

			var rectangle = new Rectangle(side1, side2);
			Console.WriteLine($"Площадь = {rectangle.Area}, Периметр = {rectangle.Perimeter}");
		}
	}

	class Rectangle
	{
		private double _side1, _side2;

		public Rectangle(double side1, double side2) {
			_side1 = side1;
			_side2 = side2;
		}

		public double AreaCalculator() {
			return _side1 * _side2;
		}

		public double PerimeterCalculator() {
			return (2 * (_side1 + _side2));
		}

		public double Area {
			get { return AreaCalculator(); }
		}
		public double Perimeter {
			get { return PerimeterCalculator(); }
		}
	}
}
