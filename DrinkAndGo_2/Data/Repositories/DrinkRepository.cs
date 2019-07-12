using DrinkAndGo_2.Data.Interfaces;
using DrinkAndGo_2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2.Data.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;
        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drinks> Drinks => _appDbContext.Drinks.Include(c => c.Category);
        public IEnumerable<Drinks> PreferredDrinks => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drinks GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinksId == drinkId);
        
    }
}
