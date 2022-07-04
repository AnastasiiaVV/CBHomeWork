using System;

namespace HomeWork_Professional_1
{
	class Program
	{
		static void Main(string[] args) {

            Console.Write("Коллекция квадратов всех нечетных чисел: ");
               foreach (object element in UserCollection.GetElements(UserCollection.CreateArr(10))) {
                    Console.Write(element + " ");
               }

            Console.ReadKey();
        }

    }
}
