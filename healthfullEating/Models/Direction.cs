using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class Direction
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string Info { get; set; } 

		public Direction ()
		{
			
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

