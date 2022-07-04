using System;

namespace HomeWork_Professional_1_1
{
	class Program
	{
		static void Main(string[] args) {
            MonthCollection months = new MonthCollection();

            months[0] = new Month("Январь",31, 1);
            months[1] = new Month("Февраль", 28, 2);
            months[2] = new Month("Март", 31, 3);
            months[3] = new Month("Апрель", 30, 4);
            months[4] = new Month("Май", 31, 5);
            months[5] = new Month("Июнь", 30, 6);
            months[6] = new Month("Июль", 31, 7);
            months[7] = new Month("Август", 31, 8);

            months[8] = new Month("Сентябрь", 30, 9);
            months[9] = new Month("Октябрь", 31, 10);
            months[10] = new Month("Ноябрь", 30, 11);
            months[11] = new Month("Декабрь", 31, 12);

            Console.WriteLine("Введите порядковый номер месяца или количество дней:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number>12 && number < 28) {
                Console.WriteLine("Нет такого месяца!");
			}
            foreach (Month month in months) {
                if (number <= 12) {
                    if (number == month.Number) {
                        Console.WriteLine($"Название: {month.Name}, количество дней: {month.Days}, порядковый номер: {month.Number}");
                    }
                } 
                else {
                    if (number == month.Days) {
                        Console.WriteLine($"Название: {month.Name}, количество дней: {month.Days}, порядковый номер: {month.Number}");
                    }
                }
            }

            Console.ReadKey();
        }

    }
}

