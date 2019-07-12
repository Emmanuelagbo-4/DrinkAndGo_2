using DrinkAndGo_2.Data.Interfaces;
using DrinkAndGo_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbcontext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;  
        }

        public IEnumerable<Category> Categories => _appDbcontext.Categories;
    }
}
