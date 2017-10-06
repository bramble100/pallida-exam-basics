using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop : List<Sweet>
    {
        internal static readonly Candy CANDY = new Candy();
        internal static readonly Lollipop LOLLIPOP = new Lollipop();
        private int sugarInventory;
        private int money;

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
            if (sugarInventory > sweet.sugarRequired)
            {
                Add(sweet);
                sugarInventory -= sweet.sugarRequired;
            }
        }

        internal void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        internal void Sell(Sweet sweet, int quantity)
        {
            throw new NotImplementedException();
        }

        internal void Raise(int raisePercentage)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            // The CandyShop should print properties represented as string in this format:
            // "Inventory: 3 candies, 2 lollipops, Income: 100, Sugar: 400gr"

            return $"Inventory:"
                + $" {FindAll(sweet => sweet.GetType() == typeof(Candy)).Count} candies"
                + $", {FindAll(sweet => sweet.GetType() == typeof(Lollipop)).Count} lollipops"
                + $", Income {money}, Sugar: {sugarInventory}gr";
        }
    }
}
