﻿using System;
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

        public void Add(Recipe E)
        {
            _dbContext.Recipes.Add(E);
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
