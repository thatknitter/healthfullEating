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

        public virtual Recipe Recipe { get; set; }

		public CSLesson (string Name, string URL)
		{
            this.CSName = Name;
            this.CSUrl = URL;
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

