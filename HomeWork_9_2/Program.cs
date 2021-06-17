using System;

namespace HomeWork_9_2
{
    class Program
    {
		static int[] MyReverse(int[] array0) {
			int j = 0;
			int[] array = new int[array0.Length];

			for (int i = array0.Length - 1; i >= 0; i--) {
				array[j] = array0[i];
				j++;
			}
			return array;
		}
        static void Main(string[] args) {
            int[] array0 = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            Console.Write("Начальный массив: ");
            PrintArray(array0);
            int[] array = MyReverse(array0);
            Console.Write("Результирующий массив: ");
            PrintArray(array);
            Console.Write("Введите индекс: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] array1 = SubArray(array0, index, count);
            PrintArray(array1);
            Console.ReadKey();
        }
        static void PrintArray(int[] array) {
            foreach (int x in array) { 
                Console.Write(x + "  ");
            }
            Console.WriteLine();
        }
        //10 8 4
        static int[] SubArray(int[] array, int index, int count) {

            int[] resultArray = new int[count];
            int k = 0;
            for (int i = index; i < array.Length; i++){

                resultArray[k] = array[i];
                k++;
			}
            if (count > (array.Length - index)) {

                for (int i = array.Length - index; i < count; i++) {

                    resultArray[i] = 1;
                }
            }
            return resultArray;
        }

    }
}  