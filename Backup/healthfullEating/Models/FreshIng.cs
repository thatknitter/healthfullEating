using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class FreshIng
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string FreshName { get; set; }
		public string FreshAmt { get; set; }
		public string FreshPrep { get; set; }
		public string FreshSpecial { get; set; }

		public FreshIng ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

