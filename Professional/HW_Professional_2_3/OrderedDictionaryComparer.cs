using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_Professional_2_3
{
	class OrderedDictionaryComparer: IEqualityComparer
	{
        public bool Equals(DictionaryEntry x, DictionaryEntry y) {
            if (x.Value != null && y.Value != null) {
                if (x.Value == y.Value) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        public bool Equals(object x, object y) {
            if (x != null && y != null) {
                if (x == y) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        public int GetHashCode(DictionaryEntry obj) {
            return obj.Value.GetHashCode();
        }

        public int GetHashCode(object obj) {
            return obj.GetHashCode();
        }
    }
}
