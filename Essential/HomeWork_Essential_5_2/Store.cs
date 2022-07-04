using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_5_2
{
	class Store {
		private Article[] _articles;

		public Store(Article[] articles) {
			_articles = articles;
		}
		public Article this[string name] {
			get {
				for (int i = 0; i < _articles.Length; i++) {
					if (_articles[i].Name == name) {
						return _articles[i];
					} 
				}
				Console.WriteLine($"Товара с именем {name} не существует.");
				return null;
			}
		}

		public Article this[int index] {
			get {
				if (index >= 0 && index < _articles.Length) {
					return _articles[index];
				} else {
					Console.WriteLine($"Товара с индексом {index} не существует.");
					return null;
				}
			}
		}

	}
}
