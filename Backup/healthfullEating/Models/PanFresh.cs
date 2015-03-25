using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class PanFresh
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string PanFreshName { get; set; }
		public string PanFreshAmt { get; set; }
		public string PanFreshPrep { get; set; }
		public string PanFreshSpecial { get; set; }

		public PanFresh ()
		{
			

		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

