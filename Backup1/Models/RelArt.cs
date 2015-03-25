using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class RelArt
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string RelName { get; set; }
		public string RelUrl { get; set; }

		public RelArt ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

