using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop : List<Sweet>
    {
        internal static readonly Candy CANDY;
        internal static readonly Lollipop LOLLIPOP;
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
            throw new NotImplementedException();
        }

        internal void PrintInfo()
        {
            throw new NotImplementedException();
        }

        internal void Sell(Sweet sweet, int quantity)
        {
            throw new NotImplementedException();
        }

        internal void Raise(int raisePercentage)
        {
            throw new NotImplementedException();
        }
    }
}
