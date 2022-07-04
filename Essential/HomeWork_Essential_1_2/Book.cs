using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_1_2
{
	public class Book {

		public Book() { }

		public Author Author {
			get; set;
		}
		public Title Title {
			get; set;
		}
		public Content Content {
			get; set;
		}

		public void SetAuthor(string author) {
			Author = new Author(author);
		}

		public void SetTitle(string title) {
			Title = new Title(title);
		}

		public void SetContent(string content) {
			Content = new Content(content);
		}

	}

}
