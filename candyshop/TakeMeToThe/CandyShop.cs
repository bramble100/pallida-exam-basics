using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class CandyShop
    {
        internal static readonly object CANDY;
        private int sugarInventory;

        public CandyShop(int sugar)
        {
            sugarInventory = sugar;
        }

        internal void BuySugar(int sugar)
        {
            sugarInventory += sugar;
        }
    }
}
