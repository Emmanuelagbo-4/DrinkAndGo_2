using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo_2.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Drinks Drinks { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
