using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class Spice
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string SpiceName { get; set; }
		public string SpiceAmt { get; set; }
		public string SpicePrep { get; set; }
		public string SpiceSpecial { get; set; }

		public Spice ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

