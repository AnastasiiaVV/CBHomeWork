using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork_Essential_11
{
	class Program
	{
		static void Main(string[] args) {
			Book book = new Book();
			book.Autor = "Александр Дюма";
			book.Name = "Три мушкитера";
			ArrayList arrayList = new ArrayList();
			arrayList.Add(book);

			int[] array = new int[] { 1, 2, 3, 4, 5 };

			arrayList.Add(array);

			for (int i = 0; i < arrayList.Count; i++) {
				Console.WriteLine(arrayList[i]);
			}
		}
	}
}
