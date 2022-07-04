using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_11_3
{
	class ArrayList
	{
		private System.Collections.ArrayList _arrayList = new System.Collections.ArrayList();
        public int Count {
            get {
                return _arrayList.Count;
            }
        }

        public string this[int index] {
            get {
                return (string)_arrayList[index];
            }
        }

        public void Add(string value) {
            _arrayList.Add(value);
        }

        public void Crear() {
            _arrayList.Clear();
        }

    }
}
