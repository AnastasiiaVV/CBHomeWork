using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_4_1
{
	class XMLHandler : AbstractHandler
	{
		public override void Chenge() {
			Console.WriteLine("Файл XML изменен");
		}

		public override void Create() {
			Console.WriteLine("Файл XML создан");
		}

		public override void Open() {
			Console.WriteLine("Файл XML открыт");
		}

		public override void Save() {
			Console.WriteLine("Файл XML сохранен");
		}
	}
}
