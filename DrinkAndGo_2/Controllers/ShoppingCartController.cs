using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndGo_2.Data.Interfaces;
using DrinkAndGo_2.Models;
using DrinkAndGo_2.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinkAndGo_2.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            _drinkRepository = drinkRepository;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrinks = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinksId == drinkId);
            if (selectedDrinks != null)
            {
                _shoppingCart.AddToCart(selectedDrinks, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrinks = _drinkRepository.Drinks.FirstOrDefault(p => p.DrinksId == drinkId);
            if (selectedDrinks != null)
            {
                _shoppingCart.RemoveFromCart(selectedDrinks);
            }
            return RedirectToAction("Index");
        }
    }
}