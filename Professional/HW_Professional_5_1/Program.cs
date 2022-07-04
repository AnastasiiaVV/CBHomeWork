using System;
using System.IO;
using System.Xml;

namespace HW_Professional_5_1
{
	class Program
	{
		static void Main(string[] args) {
			FileStream fileStream = new FileStream("TelephoneBook.xml", FileMode.Open);
			XmlTextReader xmlReader = new XmlTextReader(fileStream);
		while (xmlReader.Read()) {
				if (xmlReader.HasAttributes) {
					if (xmlReader.Name.Equals("Contact")) {
						Console.WriteLine("<{0}>", xmlReader.GetAttribute("TelephoneNumber"));
					}
				}
			}
			xmlReader.Close();
			fileStream.Close();
		}
	}
}
