using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class PanDry
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string PanDryName { get; set; }
		public string PanDryAmt { get; set; }
		public string PanDryPrep { get; set; }
		public string PanDrySpecial { get; set; }

        public virtual Recipe Recipe { get; set; }

		public PanDry (string Name, string Amount, string Prep, string Special)
		{
            this.PanDryName = Name;
            this.PanDryAmt = Amount;
            this.PanDryPrep = Prep;
            this.PanDrySpecial = Special;

		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

