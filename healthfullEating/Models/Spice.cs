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

        public virtual Recipe Recipe { get; set; }

		public Spice(string Name, string Amount, string Prep, string Special)
		{
            this.SpiceName = Name;
            this.SpiceAmt = Amount;
            this.SpicePrep = Prep;
            this.SpiceSpecial = Special;
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

