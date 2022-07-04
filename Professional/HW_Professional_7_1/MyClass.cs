using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Professional_7_1
{
	class MyClass {
		[Obsolete("Старый метод")]
		public void Message() {
			Console.WriteLine("Message");
		}

		[Obsolete("Метод не используется", true)]
		public void Error() {
			Console.WriteLine("Error");
		
		}



	}
}
