using System;
using System.IO;

namespace HW_Professional_3
{
	class Program
	{
		static void Main(string[] args) {
			DirectoryInfo directory = new DirectoryInfo(@"C:\Training");
			directory.CreateSubdirectory("Test");
			for (int i = 0; i < 100; i++) {

				directory.CreateSubdirectory(string.Format(@"Test\Folder_{0}", i));
			}
			Console.ReadKey();

			for (int i = 0; i < 100; i++) {
				Directory.Delete(string.Format(@"C:\Training\Test\Folder_{0}", i));
			}

			Directory.Delete(@"C:\Training\Test");

		}
	}
}
