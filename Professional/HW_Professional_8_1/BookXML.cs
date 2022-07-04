
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HW_Professional_8_1
{
	public class BookXML
	{
		[XmlAttribute]
		public string Name { get; set; }
		[XmlAttribute]
		public string Autor { get; set; }

		public BookXML(string name, string autor) {
			Name = name;
			Autor = autor;
		}
		public BookXML() { }

	}
}
