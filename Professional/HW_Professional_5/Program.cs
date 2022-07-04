using System;
using System.IO;
using System.Xml;

namespace HW_Professional_5
{
	class Program
	{
		static void Main(string[] args) {
            var xmlWriter = new XmlTextWriter("TelephoneBook.xml", null);

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");
            xmlWriter.WriteStartElement("Contact");
			xmlWriter.WriteStartAttribute("TelephoneNumber");
			xmlWriter.WriteString("(099)111-11-11");
			xmlWriter.WriteEndAttribute();
			xmlWriter.WriteString("Ivanov Ivan");
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndElement();

			xmlWriter.Close();

			Console.SetWindowSize(100, 30);

			FileStream fileStream = new FileStream("TelephoneBook.xml", FileMode.Open);

            XmlTextReader xmlReader = new XmlTextReader(fileStream);

			while (xmlReader.Read()) {
				Console.WriteLine("{0,-15}| {1,-15}| {2,-15}",
								xmlReader.NodeType,
								xmlReader.Name,
								xmlReader.Value);
			}

			Console.WriteLine();

            xmlReader.Close();
			
			fileStream.Close();

            Console.ReadKey();
        }
    }
}

