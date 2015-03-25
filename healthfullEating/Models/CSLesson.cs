using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class CSLesson
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string CSName { get; set; }
		public string CSUrl { get; set; }

		public CSLesson ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

