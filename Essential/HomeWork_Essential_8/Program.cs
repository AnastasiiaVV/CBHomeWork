using System;

namespace HomeWork_Essential_8
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Введите дату своего рождения (формат 2021/01/01):");
			DateTime birthdayDate = DateTime.Parse(Console.ReadLine());
			DateTime nowDate = DateTime.Now;
			int day = GetDaysToBirthday(birthdayDate, nowDate);
			if (day == 0) {
				Console.WriteLine("С днем рождения!");
			} else {
				Console.WriteLine($"До дня рождения {day} дней.");
			}
		}

		private static int GetDaysToBirthday(DateTime birthdayDate, DateTime nowDate) {
			var dayOfBYear = birthdayDate.DayOfYear;
			var dayOfNYear = nowDate.DayOfYear;
			var dayInYear = DateTime.IsLeapYear(nowDate.Year) ? 365 : 366;
			if (dayOfNYear < dayOfBYear) {
				return dayOfBYear - dayOfNYear;
			} else if (dayOfNYear == dayOfBYear) {
				return 0;
			} else {
				return dayInYear - dayOfNYear + dayOfBYear;
			}
		}

	}
}
