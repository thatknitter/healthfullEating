﻿using System;
using healthfullEating;
using System.Linq.Expressions;
using System.Linq;
using System.Collections.Generic;


namespace healthfullEating 
{
	public interface IRecipeRepository 
	{
		Recipe GetById(int id);
		Recipe GetByName(string name);
		void Add(Recipe E);
		void Delete(Recipe E);
		void Clear();
		IQueryable<Recipe> SearchFor(Expression<Func<Recipe, bool>> predicate);
        int GetCount();
        IEnumerable<Recipe> All();
	}
}
