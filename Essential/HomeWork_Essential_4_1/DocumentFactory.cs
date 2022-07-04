using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_4_1
{
	class DocumentFactory
	{
		public static AbstractHandler GetDocument(int type) {

			if (type == 1) {
				return new DOCHandler();
			} else if (type == 2) {
				return new TXTHandler();
			} else if (type == 3) {
				return new XMLHandler();
			} else {
				throw new Exception("Указанного типа не существует");
			}

		}
	}
}
