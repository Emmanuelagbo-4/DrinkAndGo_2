using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo_2.Models;

namespace DrinkAndGo_2.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drinks> Drinks { get; }
        IEnumerable<Drinks> PreferredDrinks { get; }
        Drinks GetDrinkById(int drinkId);
    }
}
