using System;

namespace HomeWork_Essential_7_1
{
    class Program {
        static void Main(string[] args) {
            var trains = new Train[] {
                new Train("Kyiv", 102, new DateTime(2021, 7, 22, 12, 0, 0)),
                new Train("Lviv", 33, new DateTime(2021, 7, 22, 13, 0, 0)),
                new Train("Uman", 1, new DateTime(2021, 7, 22, 17, 30, 0)),
                new Train("Kharkov", 45, new DateTime(2021, 7, 22, 12, 45, 0)),
                new Train("Chernigov", 54, new DateTime(2021, 7, 22, 11, 0, 0)),
                new Train("Сherkasy", 12, new DateTime(2021, 7, 22, 10, 0, 0)),
                new Train("Odessa", 99, new DateTime(2021, 7, 22, 21, 0, 0)),
                new Train("Donetsk", 23, new DateTime(2021, 7, 22, 16, 50, 0)),
            };

            Console.WriteLine("Введите номер поезда:");
            int number = Convert.ToInt32(Console.ReadLine());
            var train = trains.FindTrain(number);

            if (train.Number != number) {
                Console.WriteLine("Поезда с таким номером не существует. Хотите добавить? (yes/no)");
                string aa = Console.ReadLine();
                if (aa == "yes") {
                    Console.WriteLine("Введите пункт назначения:");
                    string city = Console.ReadLine();
                    Console.WriteLine("Введите дату и вермя отправки: (формат 2021/07/16 00:00:00)");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    var newTrain = new Train(city, number, data);
                    TrainExtention.AddTrain(ref trains, newTrain);
                    Console.WriteLine("Поезд успешно добавлен в рассписание.");
                    Console.WriteLine("");

                }
            } else {
                train.Print();
            }

            trains.SortTrain();
            Console.WriteLine("Рассписание поездов:");
			foreach (var t in trains) {
                t.Print();
			}
        }
    }
}
