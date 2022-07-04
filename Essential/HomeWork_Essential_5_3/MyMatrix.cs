using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_5_3
{
	class MyMatrix
	{
        private int[,] _matrix;
        public MyMatrix(int rows, int columns) {
            _matrix = new int[rows, columns];
            Random random = new Random();
            for (int i = 0; i < rows; i++){
                for (int j = 0; j < columns; j++) {
                    _matrix[i, j] = random.Next(-150, 150);
                }
            }
        }

        public MyMatrix (int[,] matrix){
            _matrix = matrix;
        }

        public MyMatrix this[int rows, int columns] {
            get {
                return PodMatrix(rows, columns);
            }
        }

        private MyMatrix PodMatrix(int rows, int columns) {
            int[,] podMatrix = new int[rows, columns];
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    podMatrix[i, j] = _matrix[i, j];
                }
            }
            return new MyMatrix(podMatrix);
        }

        public void Print() 
        {
            for (int i = 0; i < _matrix.GetLength(0); i++) {
                for (int j = 0; j < _matrix.GetLength(1); j++) {
                    Console.Write(_matrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }

    }
}
