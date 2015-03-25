using System;
using System.Data.Entity;



namespace healthfullEating
{
	public class Recipe
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int CookTime { get; set; }
		public int PrepTime { get; set; }
		public int ActiveCookTime { get; set; }
		public int UnattendedCookTime { get; set; }
		public int TotalTime { get; set; }
		public int Servings { get; set; }

		public Recipe ()
		{
			


		}
	}


	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}