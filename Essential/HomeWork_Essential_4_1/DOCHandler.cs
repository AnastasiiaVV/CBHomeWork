using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_4_1
{
	class DOCHandler : AbstractHandler
	{
		
		public override void Chenge() {
			Console.WriteLine("Файл DOC изменен");
		}

		public override void Create() {
			Console.WriteLine("Файл DOC создан");
		}

		public override void Open() {
			Console.WriteLine("Файл DOC открыт");
		}

		public override void Save() {
			Console.WriteLine("Файл DOC сохранен");
		}
	}
}
