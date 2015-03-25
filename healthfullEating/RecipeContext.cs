using System;
using healthfullEating;
using System.Data.Entity;
using System.Linq;


namespace healthfullEating
{
	public class RecipeContext : DbContext
	{
		public RecipeContext (string connection="healthfullEating.EventContext") : base(connection)
		{
		}

		public DbSet<Recipe> Recipes { get; set; }
	}
}

