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
            int countChain1; //создаем счётчик
            int countChain2; //создаем счётчик
            int shift; //создаем счётчик
            int randomNumber; //случайное число

            while (true) // программа будет выполняться бесконечно
            {
                randomNumber = rand.Next(3, 12); //случайное число
                countChain1  = countChain2 = 0;
				shift = randomNumber + randomNumber;

				Thread.Sleep(rand.Next(20, 5000)); //случайная пауза
                for (int i = 0; i < 40; i++) //количество итераций
                {
                    lock (locker) //критическая секция, чтобы потоки работали поочереди
					{
						for (int j = 0; j < 40; j++) {
							ClearColumn(j);
						}
						///Очищаем столбец перед заполнением его символами
						Console.CursorTop = i - countChain1; //управление курсором по вертикали
						///for (int j = i - count - 1; j < i; j++) {
						for (int j = i - countChain1 - 1; j < 40; j++) {
							Console.CursorLeft = Colunm; //управление курсором по горизонтали
							Console.WriteLine(" "); //отображаем пробелы чтобы последовательности были раздельные
						}

						if (countChain1 < randomNumber && i - countChain1 == 0) //если текущая итерация меньше случайного числа
							countChain1++; //то увеличиваем счётчик

						if (39 - i < countChain1) //если 39(максимальное значение) - счётчика цикла for меньше счётчика count
							countChain1--; // то уменьшаем счётчик

						if(i > randomNumber + countChain1 && i <= shift + countChain1) {
							countChain2++;
						}

						if (39 - i + shift < countChain2) {
							countChain2--;
						}

						if (countChain2 > 0) {
							//Console.CursorTop = i - shift - (i - shift > countChain2 ? shift - Math.Max(randomNumber, countChain2) : countChain2);
							//Console.CursorTop = i - shift - Math.Max(randomNumber, countChain2);
							Console.CursorTop = i - shift - countChain2;
							WhriteChain(countChain2);
						}

						//Console.CursorTop = i - (i > countChain1 ? Math.Max(randomNumber, countChain1) : countChain1 ) + 1; ///позиция курсора для начала отрисовки цепочки
						Console.CursorTop = i - countChain1 + 1; ///позиция курсора для начала отрисовки цепочки
						WhriteChain(countChain1);
						if (i == 39) {
							for (int j = 0; j < 40; j++) {
								ClearColumn(j);
							}
						}
						Thread.Sleep(7);
					}
				}
			}
		}

		private void WhriteChain(int count) {
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
		}

		private void ClearColumn(int cursorPosition) {

			Console.CursorLeft = Colunm; //управление курсором по горизонтали
			Console.CursorTop = cursorPosition; //управление курсором по горизонтали
			Console.WriteLine(" "); //отображаем пробелы чтобы последовательности были раздельные
		}
	}
}
