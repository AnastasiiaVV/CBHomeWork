using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_4_2
{
	class Player : IPlayable, IRecodable
	{
		private static void WhriteLine(string message) {
			Console.WriteLine(message);
		}

		public void Record() {
			WhriteLine("Запись");
		}
		public void PauseRecord() {
			WhriteLine("Запись на паузе");
		}
		public void StopRecord() {
			WhriteLine("Запись остановлена");
		}

		public void Play() {
			WhriteLine("Музыка играет");
		}
		public void PausePlay() {
			WhriteLine("Музыка на паузе");
		}
		public void StopPlay() {
			WhriteLine("Музыка остановлена");
		}
	}
}
