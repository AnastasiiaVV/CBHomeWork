using System;

namespace HomeWork_Essential_4_2
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Выберите запись(1) или проигрывание(2)");
			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 1) {
				var record = PlayerFactory.GetRecodable();
				record.Record();
				record.PauseRecord();
				record.StopRecord();
			} else if (choice == 2) {
				var play = PlayerFactory.GetPlayable();
				play.Play();
				play.PausePlay();
				play.StopPlay();
			} else {
				Console.WriteLine("Выбор не корректный");
			}


		}
	}
}
