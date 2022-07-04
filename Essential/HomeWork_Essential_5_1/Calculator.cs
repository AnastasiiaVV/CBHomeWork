using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWork_Essential_5_1
{
	class Calculator
	{
		public double GetMaxElement(double[] array) {
			double max = double.MinValue;
			for (int i = 0; i < array.Length; i++) {

				if (array[i] > max) {
					max = array[i];
				}
			}
			return max;
		}
		public double GetMinElement(double[] array) {
			double min = double.MaxValue;
			for (int i = 0; i < array.Length; i++) {
				if (array[i] < min) {
					min = array[i];
				}
			}
			return min;
		}
		public double GetSumElements(double[] array) {
			double sum = 0;
			for (int i = 0; i < array.Length; i++) {
				sum += array[i];
			}
			return sum;
		}
		public double GetSrArifmetical(double[] array) {
			double srArifm = 0;
			double sum = 0;
			for (int i = 0; i < array.Length; i++) {
				sum += array[i];
				srArifm = sum / array.Length;
			}
			return srArifm;
		}
		public double[] GetNotEvenElements(double[] array) {
			var notEven = array.Count(e => e % 2 == 1);
			double[] array2 = new double[notEven];
			int k = 0;
			for (int i = 0; i < array.Length; i++) {
				double ost = array[i] % 2;
				if (ost == 1) {
					array2[k] = array[i];
					k++;
				}
			}
			return array2;
		}

	}
}
