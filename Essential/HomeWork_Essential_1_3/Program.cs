using System;

namespace HomeWork_Essential_1_3
{
	class Program
	{
		static void Main(string[] args) {
            Point point1 = new Point("A", 1, 2);
            Point point2 = new Point("B", 1, 3);
            Point point3 = new Point("C", 2, 3);
            Point point4 = new Point("D", 2, 2);
            Point point5 = new Point("E", 3,3);
            Figure figure1 = new Figure(point1, point2, point3);
            Figure figure2 = new Figure(point1, point2, point3, point4);
            Figure figure3 = new Figure(point1, point2, point3, point4, point5);
            Console.Write("Введите колличество вершин (от 3 до 5): ");
            int count = Convert.ToInt32(Console.ReadLine());

            if (count == 3) {
                figure1.CalculatePerimeter();
                Console.WriteLine("Треугольник");
            } else if (count == 4) {
                figure2.CalculatePerimeter();
                Console.WriteLine("Четырехугольник");
            } else if (count == 5) {
                figure3.CalculatePerimeter();
                Console.WriteLine("Пятиугольник");
            } else {
                Console.WriteLine("Вы ввывели не корректное колличество!");
            }

            Console.ReadKey();
        }
    }
}
