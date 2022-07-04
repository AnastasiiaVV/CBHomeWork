using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_14_2
{
    class MyDictionary<TKey, TValue>
    {
        //private TKey[] _key = new TKey[10];
        //private TValue[] _value = new TValue[10];
        private Dictionary<TKey, TValue> _dictionary = new Dictionary<TKey, TValue>();
        public int Length { get => _dictionary.Count; }

        public MyDictionary() {
        }

        public TValue this[TKey index] {
            get {
				foreach (var item in _dictionary) {
                    if (item.Key.Equals(index)) {
                        return item.Value;
                    }
				}

                //for (int i = 0; i < _key.Length && i < Length; i++) {
                //    if (_key[i].Equals(index)) {
                //        return _value[i];
                //    }
                //}
                throw new KeyNotFoundException("Нет такого варианта!");
            }
        }

        public TValue this[int index] {
            get {
                int count = 0;
				////if (index >= 0 && index < _key.Length && index < Length) {

				//    return _value[index];
				//}

				foreach (var item in _dictionary) {

                    if (count == index) {
                        return item.Value;
                    }
                    count++;
                }
                throw new IndexOutOfRangeException("Выход за пределы массива!");
            }
        }

        public void Add(TKey key, TValue value) {
            //_key[Length] = key;
            //_value[Length] = value;
            _dictionary.Add(key, value);
            //Length++;
        }

    }
}
