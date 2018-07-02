using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageStore beverageStore = new BeverageStore();
            beverageStore.Sell();
            Console.ReadLine();
        }
    }
}
