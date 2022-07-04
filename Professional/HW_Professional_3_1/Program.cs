using System;
using System.IO;

namespace HW_Professional_3_1
{
	class Program
	{
		static void Main(string[] args) {
            FileInfo file = new FileInfo("Text.txt");
            StreamWriter writer = new StreamWriter("Text.txt");
            writer.WriteLine("Text");
            writer.Write(writer.NewLine);
            writer.Close();

            Console.WriteLine("Содержимое файла Text.txt:\n");

            StreamReader reader = new StreamReader("Text.txt");
            string input;
            while ((input = reader.ReadLine()) != null) {
                Console.WriteLine(input);
            }

            reader.Close();

        }
    }
}
