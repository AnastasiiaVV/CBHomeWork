using System;
using System.Text;
using System.Threading;

namespace HomeWork_Essential_13_1
{
	class Program
	{

		static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.ASCII;

            Console.SetWindowSize(80, 42);

            Matrix instance;

            for (int i = 0; i < 20; i++)  // количество потоков, задаеться в зависимости от необходимой частоты смены картины(значений элементов)
            {
                instance = new Matrix(i*2); //положение курсора горизонтали сдвигается с геометрической прогрессией с шагом 3
                new Thread(instance.Move).Start();
            }


            //Задержка
            Console.ReadKey();

        }
    }
}
