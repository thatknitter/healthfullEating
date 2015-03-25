using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class Equipment
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string Equip { get; set; }

		public Equipment ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

