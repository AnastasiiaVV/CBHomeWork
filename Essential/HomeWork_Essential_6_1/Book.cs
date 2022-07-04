using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_6_1
{
	class Book
	{
		private List<string> _list;
		private List<string> _listComment;

		public Notes MyNotes { get; set; }

		private string Comment { get; set; }
		public Book(List<string> list) {
			_listComment = new List<string>();
			_list = list;
			MyNotes = new Notes(this);
		}

		public List<string> FindNext(string word) {
			List<string> listRezult = new List<string>();
			foreach (var str in _list) {
				if (str.Contains(word)) {
					listRezult.Add(str);
				}
			}
			return listRezult;
		}

		public class Notes {

			public List<string> BookNotes;
			public Notes(Book book) {
				BookNotes = book._listComment;
			}

			public void AddNotes(string comment) {
				BookNotes.Add(comment);
			}
		
		}
	}
}
