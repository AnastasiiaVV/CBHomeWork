using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HW_Professional_4_3
{
	class Program
	{
		static void Main(string[] args) {
            var myCulture = CultureInfo.CurrentCulture;
            var usCulture = new CultureInfo("en-US");



            string text = File.ReadAllText("text.txt", Encoding.Default);
            string date = @"(\d\d).(\d\d).(\d\d)";
            string a1 = Regex.Replace(text, date, (m) => double.Parse(m.Value.Replace('.', '/')).ToString("C", usCulture));

            string currencySyffix = " грн";
            string patern = @"[0-9]+[\.\,][0-9]+" + currencySyffix;

            string sentence1 = Regex.Replace(text, patern, (m) => {
                var str = double.Parse(m.Value.Replace(currencySyffix, string.Empty).Replace('.', ',')).ToString("C", myCulture);
                return str;
            });
            string sentence2 = Regex.Replace(text, patern, (m) => double.Parse(m.Value.Replace(currencySyffix, string.Empty).Replace('.', ',')).ToString("C", usCulture));
			Console.WriteLine("Чек:");
            Console.WriteLine(sentence1);

            Console.WriteLine(new string('-', 25));
            Console.WriteLine("Receipt:");
			Console.WriteLine(a1);
            Console.WriteLine(sentence2);

            Console.ReadKey();
        }
	}
}
