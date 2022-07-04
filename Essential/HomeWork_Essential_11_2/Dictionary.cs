using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_11_2
{
	class Dictionary<TKey,TValue>
	{
        private System.Collections.Generic.Dictionary<TKey, TValue> _dictionary = new System.Collections.Generic.Dictionary<TKey, TValue>();

        public int Count { get {
                return _dictionary.Count;
            }
        }

        public TValue this[TKey index] {
            get {
                return _dictionary[index];
            }
        }

        public void Add(TKey key, TValue value) {
            _dictionary.Add(key, value);
        }

    }
}
