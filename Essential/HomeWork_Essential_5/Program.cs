using System;

// Индексаторы.

namespace Indexers
{
    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary["карандаш"]);
            Console.WriteLine(dictionary["яблоко"]);
            Console.WriteLine(dictionary["сонце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
                        
            // Delay.
            Console.ReadKey();
        }
    }
}
