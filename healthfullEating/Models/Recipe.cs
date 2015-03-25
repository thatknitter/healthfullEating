using System;
using System.Data.Entity;
using System.Collections.Generic;



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

        public virtual ICollection<FreshIng> FreshIngs { get; set; }
        public virtual ICollection<CSLesson> CSLessons { get; set; }
        public virtual ICollection<FHLesson> FHLessons { get; set; }
        public virtual ICollection<RelArt> RelArts { get; set; }
        public virtual ICollection<Direction> Directions { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<PanDry> PanDrys { get; set; }
        public virtual ICollection<PanFresh> PanFreshes { get; set; }
        public virtual ICollection<RecQuickOverview> RecQuickOverviews { get; set; }

		public Recipe(string RecipeName, string RecipeDesc, int Cook, int Prep, int Act, int Untend, int Total, int Serve)
		{
            this.Name = RecipeName;
            this.Description = RecipeDesc;
            this.CookTime = Cook;
            this.PrepTime = Prep;
            this.ActiveCookTime = Act;
            this.UnattendedCookTime = Untend;
            this.TotalTime = Total;
            this.Servings = Serve;


		}
	}


	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}