using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace HW_Professional_4_1
{
	class Program
	{
		static void Main(string[] args) {
			Console.Write("Введите адрес сайта: ");
			string url = Console.ReadLine();
			WebRequest reguest = WebRequest.Create(url);
			WebResponse response = reguest.GetResponse();
			Stream dataStream = response.GetResponseStream();
			StreamReader reader = new StreamReader(dataStream);
			string responseServer = reader.ReadToEnd();
			reader.Close();
			response.Close();

			StreamWriter writer = new StreamWriter("Text.txt");

			var regexHref = new Regex(@"href='(?<link>\S+)'>");
			foreach (Match item in regexHref.Matches(responseServer)) {
				writer.WriteLine("Link: {0,-25}", item.Groups["link"]);
			}

			var regexPhone = new Regex(@"(?<phone>[(0-9)\s]{2,}[0-9]{3}[\s\-][0-9]{2}[\s\-][0-9]{2})");
			foreach (Match m in regexPhone.Matches(responseServer)) {
				writer.WriteLine("Phone number: {0,-25}", m.Groups["phone"]);
			}

			var regexEmail = new Regex(@"(?<email>[0-9A-Za-z_.-]+@[0-9a-zA-Z-]+\.[a-zA-Z]{2,4})");
			foreach (Match item in regexEmail.Matches(responseServer)) {
				writer.WriteLine("Email: {0, -25}", item.Groups["email"]);
			}
			Console.WriteLine("Данные успешно записаны в файл!");
			writer.Close();

			Console.ReadLine();
		}

	}
}
