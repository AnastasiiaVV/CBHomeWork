using System;

namespace HomeWork_Essential_1
{
	class Program
	{
		static void Main(string[] args) {

            Address address = new Address();
            address.Country = "Ukraine";
            address.City = "Kiev";
            address.Street = "Obolonskyy";
            address.House = "10b";
            address.Apartment = "1";
            address.Index = "04205";
            Console.WriteLine(address.Country);
            Console.WriteLine(address.City);
            Console.WriteLine(address.Street);
            Console.WriteLine(address.House);
            Console.WriteLine(address.Apartment);
            Console.WriteLine(address.Index);

            Console.ReadKey();
        }
    }
}

    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
        public string Index { get; set; }

    }

