using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class FreshIng
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string FreshName { get; set; }
		public string FreshAmt { get; set; }
		public string FreshPrep { get; set; }
		public string FreshSpecial { get; set; }

        public virtual Recipe Recipe { get; set; }

		public FreshIng(string Name, string Amount, string Prep, string Special)
		{
            this.FreshName = Name;
            this.FreshAmt = Amount;
            this.FreshPrep = Prep;
            this.FreshSpecial = Special;
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

