using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_15_1
{
	struct Worker
	{
		private string _position;
		private int _yearOffer;

		public string Name { get; set; }

		public Worker(string name, string position, int yearOffer) {
			Name = name;
			_position = position;
			_yearOffer = yearOffer;
		}

		public int GetExperience() {
			if (_yearOffer > 1950 && _yearOffer < DateTime.Now.Year) {
				return DateTime.Now.Year - _yearOffer;
			} else {
				throw new FormatException($"Неверный формат года у сотрудника {Name}!");
			}
		}
	}

}
