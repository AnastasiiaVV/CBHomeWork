using System;
using System.Xml.Serialization;
using System.IO;


namespace HW_Professional_8_1
{
	class Program
	{
		static void Main(string[] args) {
			Book book = new Book("J. R. R. Tolkien", "The Hobbit");
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));
			FileStream fileStream = new FileStream("Book.xml", FileMode.Create, FileAccess.Write);
			xmlSerializer.Serialize(fileStream, book);

			fileStream.Close();

			BookXML bookXML = new BookXML("J. R. R. Tolkien", "The Lord of the Rings");
			XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(BookXML));
			FileStream fileStream1 = new FileStream("BookXML.xml", FileMode.Create, FileAccess.Write);
			xmlSerializer1.Serialize(fileStream1,bookXML );

			fileStream1.Close();

		}
	}
}
