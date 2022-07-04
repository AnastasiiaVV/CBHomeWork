using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_16_3
{
	class Date {

		private DateTime _date;

		public int Day { get { return _date.Day; } }
		public int Month {  get { return _date.Month; } }
		public int Year {  get { return _date.Year; } }


		public Date(DateTime date) {
			_date = date;
		}

		public static DateTime operator +(Date a, int count){
				return a._date.AddDays(count);
		}

		public static int operator -(Date a, Date b) {
			return (a._date - b._date).Days;
		}

		public override string ToString() {
			return $"{Day}.{Month}.{Year}";
		}
	}
}

