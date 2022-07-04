using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_Essential_16_2
{
	class House
	{
		public string Name { get; set; }
		public int Storey { get; set; }
		public List<Flat> Flats { get; set; }

		public House(string name, int storey, List<Flat> flats) {
			Name = name;
			Storey = storey;
			Flats = flats;
		}

		public House Clone() {
			return (House)MemberwiseClone();
		}

		public House DeepClone() {
			string nameNew = new String(Name.ToCharArray());
			List<Flat> flats = new List<Flat>();
			foreach (var flat in Flats) {
				flats.Add(new Flat(flat.Number, flat.RoomCount, flat.Floor));
			}
			return new House(nameNew, Storey, flats);
		}

	}
}
