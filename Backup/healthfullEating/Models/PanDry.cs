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

		public PanDry ()
		{
			

		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

