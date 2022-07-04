using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Professional_1_1
{
	class MonthCollection
	{
        readonly Month[] months = new Month[12];

        public Month this[int index] {
            get { return months[index]; }
            set { months[index] = value; }
        }

        int position = -1;

        public bool MoveNext() {
            if (position < months.Length - 1) {
                position++;
                return true;
            }

            return false;
        }

         public object Current {
            get { return months[position]; }
        }


        public MonthCollection GetEnumerator() {
            return this;
        }

    }
}
