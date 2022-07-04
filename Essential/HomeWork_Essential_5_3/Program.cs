using System;
using System.Collections.Generic;
using System.Text;


namespace HomeWork_Essential_5_3
{
    class Program
    {
        public static void Main() {
            int rows, columns, rowsPMatr, columnsPMatr;
            Console.Write("Введите количество строк матрицы: ");
            rows = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Введите количество столбцов матрицы: ");
            columns = Convert.ToInt32((Console.ReadLine()));
            MyMatrix myMatrix = new MyMatrix(rows, columns);
            myMatrix.Print();

            Console.WriteLine("Выводим на экран подматрицу:");
            Console.Write("Введите количество строк подматрицы: ");
            rowsPMatr = Convert.ToInt32((Console.ReadLine()));
            Console.Write("Введите количество столбцов подматрицы: ");
            columnsPMatr = Convert.ToInt32((Console.ReadLine()));

            MyMatrix podMatrix = myMatrix[rowsPMatr, columnsPMatr];
            podMatrix.Print();
            Console.ReadKey();

        }
    }
}