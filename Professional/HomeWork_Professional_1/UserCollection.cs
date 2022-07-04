using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HomeWork_Professional_1
{
    class UserCollection
    {
        public static int[] CreateArr(int N) {
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++) {
                array[i] = i;
            }
            return array;
        }

        public static IEnumerable<double> GetElements(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                if ((arr[i] & 1) != 0) {
                    yield return Math.Pow(arr[i], 2);
                }
            }
        }

    }
}
