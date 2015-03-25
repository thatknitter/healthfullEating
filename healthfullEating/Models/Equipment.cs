using System;
using System.Data.Entity;

namespace healthfullEating
{
	public class Equipment
	{
		public int ID { get; set; }
		public int RecipeID { get; set; }
		public string Equip { get; set; }

        public virtual Recipe Recipe { get; set; }

		public Equipment (string Item)
		{
            this.Equip = Item;
		}
	}

	public class RecipeDBContext : DbContext
	{
		public DbSet<Recipe> Recipes { get; set; }
	}
}

