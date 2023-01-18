using Proiect3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect3
{
    public class Cart
    {
        public static List<ProductModel> cart = new List<ProductModel>();

        public static void resetCart()
        {
            cart.Clear();
        }

        public static void addToCart(ProductModel product)
        {
            cart.Add(product);
        }
    }
}