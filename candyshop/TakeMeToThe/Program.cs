﻿using System;

namespace TakeMeToThe
{
    public class TakeMeToThe
    {
        public static void Main(string[] args)
        {
            // We run a Candy shop where we sell candies and lollipops
            // One lollipop's price is 10$
            // And it made from 5gr of sugar
            // One candie's price is 20$
            // And it made from 10gr of sugar
            // we can raise their prices with a given percentage

            // Create a CandyShop class
            // It can store sugar and money as income.
            // we can create lollipops and candies store them in the CandyShop's storage
            
            CandyShop candyShop = new CandyShop(300);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.CANDY);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.CreateSweets(CandyShop.LOLLIPOP);
            candyShop.PrintInfo();
            // Should print out:
            // Invetory: 2 candies, 2 lollipops, Income: 0$, Sugar: 270gr
            candyShop.Sell(CandyShop.CANDY, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 2 lollipops, Income: 20$, Sugar: 285gr"
            candyShop.Raise(5);
            candyShop.Sell(CandyShop.LOLLIPOP, 1);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 35$, Sugar: 285gr"
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
            // Should print out:
            // "Invetory: 1 candies, 1 lollipops, Income: 5$, Sugar: 315gr"
            Console.ReadKey();
        }
    }
}