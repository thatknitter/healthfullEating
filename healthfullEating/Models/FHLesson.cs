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

        public virtual Recipe Recipe { get; set; }

		public FHLesson (string Name, string URL)
		{
            this.FHName = Name;
            this.FHUrl = URL;
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

