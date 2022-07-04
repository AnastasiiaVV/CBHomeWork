using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_4_1
{
	class TXTHandler : AbstractHandler
	{
		public override void Chenge() {
			Console.WriteLine("Файл TXT изменен");
		}

		public override void Create() {
			Console.WriteLine("Файл TXT создан");
		}

		public override void Open() {
			Console.WriteLine("Файл TXT открыт");
		}

		public override void Save() {
			Console.WriteLine("Файл TXT сохранен");
		}
	}
}
