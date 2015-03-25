using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class FHLesson
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string FHName { get; set; }
		public string FHUrl { get; set; }

		public FHLesson ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

