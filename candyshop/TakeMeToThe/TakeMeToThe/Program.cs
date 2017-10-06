using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    class Program
    {
        static void Main(string[] args)
        {
            CandyShop candyShop = new CandyShop(300);

            candyShop.CreateSweetsCandy();
            candyShop.CreateSweetsCandy();
            candyShop.CreateSweetsLollipop();
            candyShop.CreateSweetsLollipop();
            candyShop.PrintInfo();
            //candyShop.Sell(CandyShop.CANDY, 1); - Not found solution yet
            candyShop.PrintInfo();           
            candyShop.Raise(5);
            //candyShop.Sell(CandyShop.LOLLIPOP, 1); - Not found solution yet
            candyShop.PrintInfo();
            candyShop.BuySugar(300);
            candyShop.PrintInfo();
        }
    }
}
