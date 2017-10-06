using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeMeToThe
{
    public class CandyShop
    {
        public int SugarStock = 0;
        public double Income = 0;

        public CandyShop(int sugarStock)
        {
        }

        Sweets sweets = new Sweets();
        public List<Sweets> StorageOfCandyShop = new List<Sweets>();
        
        public void CreateSweetsLollipop()
        {
            if (SugarStock > 5)
            {
                Lollipops newlollipops = new Lollipops();
                StorageOfCandyShop.Add(newlollipops);
                SugarStock -= 5;
            }           
        }

        public void CreateSweetsCandy()
        {
            if (SugarStock > 10)
            {
                Candies newCandy = new Candies();
                StorageOfCandyShop.Add(newCandy);
                SugarStock -= 10;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Inventory:" + Inventory + "Sugar: " + SugarStock+ " Income: " + Income);
        }

        public void Raise(double raisePercentage)
        {
            sweets.price = sweets.price * raisePercentage / 100;
        }        

        public void BuySugar(int volume)
        {
            SugarStock = SugarStock + volume;
            Income = Income - volume * 10;
        }
    }
}
