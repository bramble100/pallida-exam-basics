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
        private int sugarInventory;
        private int money;
        Dictionary<Type, int> inventoryOfSweets = new Dictionary<Type, int>();

        // One lollipop's price is 10$
        // One candie's price is 20$

        Dictionary<Type, int> prices = new Dictionary<Type, int>()
        {
            {typeof(Candy), 20 },
            {typeof(Lollipop), 10 }
        };

        public CandyShop(int sugar)
        {
            // The constructor should take the amount of sugar in gramms.
            sugarInventory = sugar;
        }

        internal void BuySugar(int sugar)
        {
            sugarInventory += sugar;
        }

        internal void CreateSweets(Sweet sweet)
        {
            // If we create a candie or lollipop the CandyShop's sugar amount gets reduced by the amount needed to create the sweets

            if (inventoryOfSweets.ContainsKey(sweet.GetType()))
            {
                if (sugarInventory > sweet.SugarRequired)
                {
                    inventoryOfSweets[sweet.GetType()]++;
                    sugarInventory -= sweet.SugarRequired;
                }
            }
            else
            {
                inventoryOfSweets[sweet.GetType()] = 1;
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
                }
            }
        }

        internal void Raise(int raisePercentage)
        {
            // We can raise the prices of all candies and lollipops with a given percentage

            prices[typeof(Candy)] *= (1 + raisePercentage);
            prices[typeof(Lollipop)] *= (1 + raisePercentage);
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
