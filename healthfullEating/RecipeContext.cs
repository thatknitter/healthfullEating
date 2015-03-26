using System;
using healthfullEating;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace healthfullEating
{
	public class RecipeContext : DbContext
	{
		public RecipeContext (string connection="healthfullEating.EventContext") : base(connection)
		{
		}

		public DbSet<Recipe> Recipes { get; set; }
        public DbSet<FreshIng> FreshIngs { get; set; }
        public DbSet<PanFresh> PanFreshs { get; set; }
        public DbSet<PanDry> PanDrys { get; set; }
        public DbSet<CSLesson> CSLessons { get; set; }
        public DbSet<Direction> Directions { get; set; }
	}
}

