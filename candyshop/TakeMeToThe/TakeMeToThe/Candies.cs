using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class Candies : Sweets
    {
        public Candies()
        {
        }

        public Candies(double price, int sugar)
        {
            this.price = 20;
            this.sugar = 10;
        }
    }
}
