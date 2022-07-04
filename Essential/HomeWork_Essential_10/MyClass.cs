using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_10
{
	class MyClass<T> where T : new()
	{
		public static T FactoryMethod() {
			return new T();
		}

	}
}
