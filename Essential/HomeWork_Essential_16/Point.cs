using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_16
{
	struct Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }

		public Point(int x, int y, int z) {
			X = x;
			Y = y;
			Z = z;
		}

		public static Point operator +(Point a, Point b)
			=> new Point(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

		public override string ToString() {
			return $"Point {X},{Y},{Z}";
		}

	
	}
}
