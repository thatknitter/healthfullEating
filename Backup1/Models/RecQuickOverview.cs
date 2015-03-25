using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class RecQuickOverview
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string QuickOver { get; set; }

		public RecQuickOverview ()
		{
			
		}

	}
	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

