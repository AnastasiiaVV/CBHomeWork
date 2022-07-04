using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_Professional_4_2
{
	class Program
	{
		static void Main(string[] args) {
			string text = File.ReadAllText("text.txt");
			Console.WriteLine("Считывание файла");
			string patern = @"\s[а-я]{1,3}\s";
			Console.WriteLine("Замена предлогов");
			string newText = Regex.Replace(text, patern, " ГАВ! ");
			Console.WriteLine("Запись в новый файл");
			File.WriteAllText("text_new.txt", newText);
			Console.ReadKey();
		}
	}
}
