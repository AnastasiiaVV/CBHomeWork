using System;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork_Essential_13
{
	class Program
	{
		private static void MethodA() {
			Task.Delay(1000).Wait();
			Console.WriteLine($"Name '{Thread.CurrentThread.Name}', Id '{Thread.CurrentThread.ManagedThreadId}'");
			if (Thread.CurrentThread.ManagedThreadId > 100) {
				return;
			} else {
				ThreadStart writeSecond = new ThreadStart(MethodA);
				Thread thread = new Thread(writeSecond);
				thread.Start();
			}
		}

		static void Main(string[] args) {
			MethodA();
		}

	}
}
