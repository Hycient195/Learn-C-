using System;
namespace HelloWorld
{
	public class Weapon
	{
		public string Name { get; set; }
		public int Price { get; set; }

		public Weapon(string name, int price)
		{
			Name = name;
			Price = price;
		}
	}

	public class Arsenal
	{
		public List<Weapon> Weapons { get; set; }

		public IEnumerable<Weapon> GetWeapons()
		{
			return new List<Weapon>
			{
				new Weapon("Shotgun", 84),
				new Weapon("Gattling Gun", 250),
				new Weapon("Rifle", 56),
				new Weapon("Rifle", 60),
				new Weapon("Grenade", 25)
			};
        }
	}

	public class LINQ
	{
		public static void EntryPoint()
		{
            var arsenal = new Arsenal().GetWeapons();

			/* Using Query Expressions */
			var selected = from weapon in arsenal
						   where weapon.Price < 65
						   orderby weapon.Name
						   select weapon.Name;

			foreach (var item in selected)
				Console.WriteLine("Query expression gives: " + item);


			/* Similarly Using Lambda Expressions */
			var lamSelected = arsenal.Where(x => x.Price < 65)
									 .OrderBy(x => x.Name)
									 .Select(x => x.Name);

			foreach (var item in lamSelected)
				Console.WriteLine("Lambda expression gives: " + item);



			// Filtering by a particular property from an Enumerable
			var cheapWeapons = arsenal.Where(x => x.Price < 65); // Can be used like both javascript's filter and map methods
            foreach (var price in cheapWeapons)
                Console.WriteLine("Cheap weapon with price: " + price);

			// Selecting a particular property from an Enumberable
			var selectedWeapons = arsenal.Select(x => x.Name); // Can be used like Javascript's forEach method
			foreach (var weapon in selectedWeapons)
				Console.WriteLine("Only weapon name selected: " + weapon);

			// Ordering an Enumerable
			var orderedWeapons = arsenal.OrderBy(x => x.Name);
            foreach (var weapon in orderedWeapons)
                Console.WriteLine("Weapons orderd in alphabetical order: " + weapon.Name);

			// Skipping and taking on a Enumerable
            var skippedWeapons = arsenal.Skip(2).Take(3);
            foreach (var weapon in skippedWeapons)
                Console.WriteLine("Two weapons skipped: " + weapon.Name);



            // Single, similar to javascript's Find method.
            var single = arsenal.Single(x => x.Price == 250); // Same as below, but throws an error if not occourence is found
            var singles = arsenal.SingleOrDefault(x => x.Price == 250); // Gets a single value meeting specified requirement, default if the element is not found, and an exception if more that 1 occoourence is found.

            var first = arsenal.First(x => x.Name == "Rifle"); // Returns first occourence that meets the crieterion
            var firsts = arsenal.FirstOrDefault(x => x.Name == "Rifle"); // The default variant behaves same as "SingleORDefault"

            var last = arsenal.Last(x => x.Name == "Rifle");
            var lasts = arsenal.LastOrDefault(x => x.Name == "Rifle");

            Console.WriteLine(arsenal.Sum(x => x.Price));
            Console.WriteLine(arsenal.Max(x => x.Price));
            Console.WriteLine(arsenal.Min(x => x.Price));
            Console.WriteLine(arsenal.Count());
            Console.WriteLine(arsenal.Average(x => x.Price));

            foreach (var weapon in arsenal)
                Console.WriteLine(weapon.Name);
        }
	}
}

/* LINQ, an acronym for Langauge Integrated Query in C# is a feature that provides a mechanism
 * for querying and maniuplating data from different sources in C# sucy as Enumerables,
 * databases, XML and collections. 
 
	LINQ in C# has two basic formats or expressions which are the "Query Expressions" and the
   "Lambda Expressions". The query expression takes the form of SQL statements, while the
   Lambda expressions take the form of C# lambda expressions. The lambda expressions are more
   feature rich. */