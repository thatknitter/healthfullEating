using System;
using healthfullEating;
using System.Data.Entity;
using System.Linq;
using healthfullEating.Models;

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

		public DbSet<Models.Recipe> GetDbSet()
		{
			return _dbContext.Recipe;
		}

		public Models.Recipe GetById(int id)
		{
			var query = from Recipe in _dbContext.Recipes
						where Recipe.ID == id
						select Recipe
		}

	}
}
