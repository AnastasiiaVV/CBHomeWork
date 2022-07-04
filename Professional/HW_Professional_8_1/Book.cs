using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Professional_8_1
{
	public class Book
	{
		public string Name { get; set; }

		public string Autor { get; set; }

		public Book(string name, string autor) {
			Name = name;
			Autor = autor;
		}

		public Book() { }

	}
}
