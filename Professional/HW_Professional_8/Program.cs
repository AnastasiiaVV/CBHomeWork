using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HW_Professional_8
{
	class Program
	{
		static void Main(string[] args) {
			Book book = new Book("J. R. R. Tolkien", "The Hobbit");

			FileStream fileStream = File.Create("Book.txt");
			BinaryFormatter binaryFormatter = new BinaryFormatter();

			binaryFormatter.Serialize(fileStream, book);
			fileStream.Close();

			FileStream fileStream1 = File.Open("Book.txt", FileMode.Open);

			Book book1 = binaryFormatter.Deserialize(fileStream1) as Book;

			fileStream1.Close();
			if (book1 != null) {
				Console.WriteLine($"{book1.Autor} {book1.Name}");
			}

		}
	}
}
