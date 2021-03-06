using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_10_3
{
	class MyList<T>
	{
		private List<T> _list;

		public MyList() {
			_list = new List<T>();
		}

		public void Add(T item) {
			_list.Add(item);

		}

		public T this[int index] {
			get { return _list[index]; }
		}

		public int Count {
			get { return _list.Count; }
		}


	}
}
