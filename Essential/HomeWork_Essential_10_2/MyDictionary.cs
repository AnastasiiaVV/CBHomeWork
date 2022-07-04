using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_10_2
{
	class MyDictionary <TKey, TValue>
	{
		private TKey[] _key = new TKey[10];
		private TValue[] _value = new TValue[10];
        public int Length { get; private set; }
        public MyDictionary() {
        }

        public TValue this[TKey index] {
            get {
                for (int i = 0; i < _key.Length && i < Length; i++) {
                    if (_key[i].Equals(index)) {
                        return _value[i];
                    }
                }
                throw new KeyNotFoundException("Нет такого варианта!");
            }
        }

        public TValue this[int index] {
            get {
                if (index >= 0 && index < _key.Length && index < Length) {
                    return _value[index];
                }
                throw new IndexOutOfRangeException("Выход за пределы массива!");
            }
        }

        public void Add(TKey key, TValue value) {
            _key[Length] = key;
            _value[Length] = value;
            Length++;
        }

    }
}
