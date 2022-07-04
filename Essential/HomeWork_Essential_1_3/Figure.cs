using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_1_3
{
	public class Figure
    {
        private Point[] _points;

        public string Name {
            get; set;
        }
        private double LengthSide(Point a, Point b) {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public void CalculatePerimeter() {
            double perimeter = 0;
            for (int i = 1; i < _points.Length; i++) {
                perimeter += LengthSide(_points[i - 1], _points[i]);
            }
            perimeter += LengthSide(_points[0], _points[_points.Length-1]);
            Console.WriteLine($"Периметр равен {perimeter}");
        }
        public Figure(Point point1, Point point2, Point point3) {
            _points = new Point[] {point1, point2, point3};
        }

        public Figure(Point point1, Point point2, Point point3, Point point4) {
            _points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5) {
            _points = new Point[] { point1, point2, point3, point4, point5 };
        }

    }
}
