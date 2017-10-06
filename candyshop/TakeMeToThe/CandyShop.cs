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
        Dictionary<Type, int> prices = new Dictionary<Type, int>()
        {
            {typeof(Candy), 20 },
            {typeof(Lollipop), 10 }
        };

        public CandyShop(int sugar)
        {
            sugarInventory = sugar;
        }

        internal void BuySugar(int sugar)
        {
            sugarInventory += sugar;
        }

        internal void CreateSweets(Sweet sweet)
        {
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
            if (inventoryOfSweets.ContainsKey(sweet.GetType()))
            {
                if (inventoryOfSweets[sweet.GetType()] > 0)
                {
                    inventoryOfSweets[sweet.GetType()]--;
                    money += prices[sweet.GetType()];
                }
            }
        }

        internal void Raise(int raisePercentage)
        {
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
