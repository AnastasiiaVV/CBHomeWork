using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_1_3
{
	public class Point
	{

		private string _name;
		private int _x, _y;

		public string Name {
			get {
				return _name;
			}
		}

		public int X {
			get {
				return _x;
			}
		}

		public int Y {
			get {
				return _y;
			}
		}

		public Point(string name, int x, int y) {
			_name = name;
			_x = x;
			_y = y;

		}

	}
}
