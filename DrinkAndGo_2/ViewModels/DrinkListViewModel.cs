using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo_2.Models;

namespace DrinkAndGo_2.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drinks> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
