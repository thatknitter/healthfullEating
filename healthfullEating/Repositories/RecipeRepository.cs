using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using healthfullEating;
using System.Data.Entity;
using System.Linq;

namespace healthfullEating
{
	public class RecipeRepository : IRecipeRepository 
	{
		private RecipeContext _dbContext;

		public RecipeRepository(string connection = "healthfullEating.RecipeContext")
		{
			_dbContext = new RecipeContext (connection);
			_dbContext.Recipes.Load();
		}

		public RecipeContext Context()
		{
			return _dbContext;
		}

		public DbSet<Recipe> GetDbSet()
		{
			return _dbContext.Recipes;
            
		}

        public int GetCount()
        {
            return _dbContext.Recipes.Count<Recipe>();

        }

		public Recipe GetById(int id)
		{
            var query = from Recipe in _dbContext.Recipes
                        where Recipe.ID == id
                        select Recipe;
            return query.First<Recipe>();
		}

        public Recipe GetByName(string name)
        {
            var query = from Recipe in _dbContext.Recipes
                        where Recipe.Name == name
                        select Recipe;
            return query.First<Recipe>();
        }

        public void Add(Recipe name)
        {
            _dbContext.Recipes.Add(name);
            _dbContext.SaveChanges();
        }

        public void Add(FreshIng fresh)
        {
            _dbContext.FreshIngs.Add(fresh);
            _dbContext.SaveChanges();
        }

        public void Add(PanFresh pantry)
        {
            _dbContext.PanFreshs.Add(pantry);
            _dbContext.SaveChanges();
        }

        public void Add(PanDry dry)
        {
            _dbContext.PanDrys.Add(dry);
            _dbContext.SaveChanges();
        }

        public void Add(CSLesson cs)
        {
            _dbContext.CSLessons.Add(cs);
            _dbContext.SaveChanges();
        }

        public void Add(Direction info)
        {
            _dbContext.Directions.Add(info);
            _dbContext.SaveChanges();
        }

        public void Add(Equipment item)
        {
            _dbContext.Equipments.Add(item);
            _dbContext.SaveChanges();
        }

        public void Add(FHLesson fh)
        {
            _dbContext.FHLessons.Add(fh);
            _dbContext.SaveChanges();
        }

        public void Add(RecQuickOverview quick)
        {
            _dbContext.RecQuickOverviews.Add(quick);
            _dbContext.SaveChanges();
        }

        public void Add(RelArt article)
        {
            _dbContext.RelArts.Add(article);
            _dbContext.SaveChanges();
        }

        public void Add(Spice herb)
        {
            _dbContext.Spices.Add(herb);
            _dbContext.SaveChanges();
        }

        public void Delete(Recipe E)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> All()
        {
            var qu = from Recipe in _dbContext.Recipes select Recipe;
            return qu.ToList<Recipe>();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.Recipes.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IQueryable<Recipe> SearchFor(System.Linq.Expressions.Expression<Func<Recipe, bool>> predicate)
        {
            throw new NotImplementedException();
        }
	}
}
