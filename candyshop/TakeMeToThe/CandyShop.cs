using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        internal static readonly Candy CANDY = new Candy();
        internal static readonly Lollipop LOLLIPOP = new Lollipop();
        // The price of 1000gr sugar is 100$
        private static decimal sugarPrice = 0.1m;

        private int sugarInventory;
        private decimal money;
        Dictionary<Type, int> inventoryOfSweets = new Dictionary<Type, int>();

        // One lollipop's price is 10$
        // One candie's price is 20$
        Dictionary<Type, decimal> prices = new Dictionary<Type, decimal>()
        {
            {typeof(Candy), 20m },
            {typeof(Lollipop), 10m }
        };

        public CandyShop(int sugar)
        {
            // The constructor should take the amount of sugar in gramms.
            sugarInventory = sugar;
            Console.WriteLine("CandyShop created.");
            Console.WriteLine(ToString());
        }

        internal void BuySugar(int sugar)
        {
            // We can buy sugar with a given number as amount.
            // If we buy sugar we can raise the CandyShop's amount of sugar and reduce the income by the price of it.
            if(money >= sugar * sugarPrice)
            {
                sugarInventory += sugar;
                money -= sugar * sugarPrice;
                Console.WriteLine($"{sugar}g sugar bought for {sugar * sugarPrice}");
                Console.WriteLine(ToString());
            }
            else
            {
                Console.WriteLine($"Not enough money for buying {sugar}g sugar ({sugar * sugarPrice} needed, but only {money} available).");
                Console.WriteLine(ToString());
            }
        }

        internal void CreateSweets(Sweet sweet)
        {
            // If we create a candie or lollipop the CandyShop's sugar amount gets reduced by the amount needed to create the sweets

            if (sugarInventory > sweet.SugarRequired)
            {
                if (!inventoryOfSweets.ContainsKey(sweet.GetType()))
                {
                    inventoryOfSweets[sweet.GetType()] = 0;
                }
                inventoryOfSweets[sweet.GetType()]++;
                sugarInventory -= sweet.SugarRequired;
                Console.WriteLine($"One pcs of {sweet.GetType().Name} created");
                Console.WriteLine(ToString());
            }
            else
            {
                Console.WriteLine($"No {sweet.GetType().Name} created");
                Console.WriteLine(ToString());
            }
        }

        internal void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        internal void Sell(Sweet sweet, int quantity)
        {
            // We can sell candie or lollipop with a given number as amount
            // If we sell sweets the income will be increased by the price of the sweets and we delete it from the inventory

            if (inventoryOfSweets.ContainsKey(sweet.GetType()))
            {
                if (inventoryOfSweets[sweet.GetType()] >= quantity)
                {
                    inventoryOfSweets[sweet.GetType()] -= quantity;
                    money += prices[sweet.GetType()]* quantity;

                    Console.WriteLine($"{quantity} pcs of {sweet.GetType().Name} sold for {prices[sweet.GetType()]*quantity}");
                    Console.WriteLine(ToString());

                }
            }
        }

        internal void Raise(decimal raisePercentage)
        {
            // We can raise the prices of all candies and lollipops with a given percentage

            prices[typeof(Candy)] *= (100 + raisePercentage)/100;
            prices[typeof(Lollipop)] *= (100 + raisePercentage)/100;
            Console.WriteLine($"The prices are raised by {raisePercentage}%, new prices are: Candy:{prices[typeof(Candy)]} and Lollipop: {prices[typeof(Lollipop)]}");
        }

        public override string ToString()
        {
            // The CandyShop should print properties represented as string in this format:
            // "Inventory: 3 candies, 2 lollipops, Income: 100, Sugar: 400gr"

            return $"Inventory:"
                + $" {(inventoryOfSweets.ContainsKey(typeof(Candy)) ? inventoryOfSweets[typeof(Candy)] : 0)} candies"
                + $" {(inventoryOfSweets.ContainsKey(typeof(Lollipop)) ? inventoryOfSweets[typeof(Lollipop)]: 0)} lollipops"
                + $", Income {money}, Sugar: {sugarInventory}gr";
        }
    }
}
