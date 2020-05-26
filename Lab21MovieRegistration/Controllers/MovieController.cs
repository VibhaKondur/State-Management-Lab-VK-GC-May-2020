using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab21MovieRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
using System.Text.Json;

namespace Lab21MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> Movies = new List<Movie>()
        {
            new Movie(0, "Dude, Where's My Car?", "Comedy", 120, 2000, 6.99),
            new Movie(1, "Miss Congeniality", "Comedy", 95, 2000, 6.99),
            new Movie(2, "Training Day", "Drama", 125, 2001, 6.99),
            new Movie(3, "Insidious", "Horror", 180, 2010, 6.99),
            new Movie(4, "Galaxy Quest", "Comedy", 90, 1999, 6.99),
            new Movie(5, "Autumn in New York", "Drama", 120, 2000, 6.99),
            new Movie(6, "Bridget Jones's Diary", "Comedy", 95, 2001, 6.99),
            new Movie(7, "Lincoln Lawyer", "Drama", 125, 2011, 6.99),
            new Movie(8, "Cabin in the Woods", "Horror", 180, 2000, 6.99),
            new Movie(9, "Back to the Future", "Sci-Fi", 100, 1980, 6.99),


        };

        public List<Movie> shoppingCart = new List<Movie>();

        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult AddToCart(Movie movie)
        {
            SetSession(movie);

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            shoppingCart = GetShoppingCart();

            return View(shoppingCart);
        }

        public IActionResult RemoveFromCart(int index)
        {
            shoppingCart = GetShoppingCart();
            shoppingCart.RemoveAt(index);

            HttpContext.Session.SetString("shoppingCart", JsonSerializer.Serialize(shoppingCart));

            return RedirectToAction("Checkout");
        }

        public void SetSession(Movie movie)
        {
            var cart = HttpContext.Session.GetString("shoppingCart");

            if(cart != null)
            {
                shoppingCart = JsonSerializer.Deserialize<List<Movie>>(cart);
         
            }
            shoppingCart.Add(movie);

            HttpContext.Session.SetString("shoppingCart", JsonSerializer.Serialize(shoppingCart));
        }

        public List<Movie> GetShoppingCart()
        {
            var cart = HttpContext.Session.GetString("shoppingCart"); //returns string formatted as Json Data
            return JsonSerializer.Deserialize<List<Movie>>(cart);
        }

        public IActionResult Receipt()
        {
            shoppingCart = GetShoppingCart();

            return View(shoppingCart);
        }

        public IActionResult ClearCart()
        {
            shoppingCart = new List<Movie>();
            HttpContext.Session.SetString("shoppingCart", JsonSerializer.Serialize(shoppingCart));
            return RedirectToAction("Index");
        }
    }
}
