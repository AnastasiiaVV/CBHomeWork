using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClashPoyal.Models
{
	public class Language
	{
		public string Play { get; }
		public string Setting { get; }
		public string ConfigLang { get; }
		public string ConfigMap { get; }
		public string ConfigBack { get; }
		public Language(string choose) {
			if (choose == "UA") {
				Play = "Грати";
				Setting = "Налаштування";
				ConfigLang = "Вибiр мови";
				ConfigMap = "Вибiр карти";
				ConfigBack = "До головного меню";
			} else if (choose == "ENG") {
				Play = "Play";
				Setting = "Settings";
				ConfigLang = "Language";
				ConfigMap = "Map";
				ConfigBack = "Back to menu";
			}
		}
	}
}
