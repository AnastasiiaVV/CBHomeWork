using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeWork_Essential_13_1
{
    class Matrix
    {
        static object locker = new object(); //ссылука на объект который будет использован для ограничения доступа в критическую секцию

        Random rand;

        const string litters = "abcdefghigk"; //символы которые бужут на консоли

        public int Colunm { get; set; } //обработчик колонки(колонка)


        public Matrix(int col) {
            Colunm = col;
            rand = new Random((int)DateTime.Now.Ticks); // случайное число
        }

        //[rand.Next(0, 9)] конструкция обращения по случайному индексу к элементу
        private char GetChar() {
            /*litters.ToCharArray()*/ //имя массива
            return litters.ToCharArray()[rand.Next(0, 9)]; //получение случайного числа из сгенерированого массива из чисел, и обращение к элменту по случайному индексу
        }

        public void Move() // основной метод
        {
            int count; //создаем счётчик
            int randomNumber; //случайное число

            while (true) // программа будет выполняться бесконечно
            {
                randomNumber = rand.Next(3, 12); //случайное число
                count = 0;
                Thread.Sleep(rand.Next(20, 5000)); //случайная пауза
                for (int i = 0; i < 40; i++) //количество итераций
                {
                    lock (locker) //критическая секция, чтобы потоки работали поочереди
                    {
                        ///Очищаем столбец перед заполнением его символами
                        Console.CursorTop = i - count; //управление курсором по вертикали
                        ///for (int j = i - count - 1; j < i; j++) {
                        for (int j = i - count - 1; j < 40; j++) {
                            Console.CursorLeft = Colunm; //управление курсором по горизонтали
                            Console.WriteLine(" "); //отображаем пробелы чтобы последовательности были раздельные
                        }

                        if (count < randomNumber) //если текущая итерация меньше случайного числа
                            count++; //то увеличиваем счётчик

                        if (39 - i < count) //если 39(максимальное значение) - счётчика цикла for меньше счётчика count
                            count--; // то уменьшаем счётчик
                        Console.CursorTop = i - count + 1; //передвигаем курсор
                                                           //Снизу Colunm одинаковая в этом случае
                                                           //Разное количество случайных символов
                                                           //Чем меньше счётчик тем меньше будет выдавтся символов в разделенной цепочке

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        for (int j = 0; j < count - 2; j++) {
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (count >= 2) //если пройдет проверку то на текущей итерации выполниться только раз
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if (count >= 1) //если пройдет проверку то на текущей итерации выполниться только раз
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.CursorLeft = Colunm;
                            Console.WriteLine(GetChar());
                        }
                        if(i == 39) {
                            for (int j = 0; j < 40; j++) {
                                ClearColumn(j);
                            }
                        }

                        Thread.Sleep(7); // тут регулировать скорость
                        /*for (int j = 0; j < 40; j++) {
                            ClearColumn(j);
                        }*/
                    }
                }

                


			}
        }

		private void ClearColumn(int cursorPosition) {

			Console.CursorLeft = Colunm; //управление курсором по горизонтали
			Console.CursorTop = cursorPosition; //управление курсором по горизонтали
			Console.WriteLine(" "); //отображаем пробелы чтобы последовательности были раздельные
		}
	}
}
