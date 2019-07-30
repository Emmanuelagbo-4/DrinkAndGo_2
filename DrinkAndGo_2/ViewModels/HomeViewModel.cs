using DrinkAndGo_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drinks> PreferredDrinks { get; set; }
    }
}
