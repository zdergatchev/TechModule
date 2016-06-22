using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal guests = decimal.Parse(Console.ReadLine());
            decimal bananas = decimal.Parse(Console.ReadLine());
            decimal eggs = decimal.Parse(Console.ReadLine());
            decimal berries = decimal.Parse(Console.ReadLine());

            decimal portions = (int)guests / 6;

            if (guests % 6 != 0)
            {
                portions++;
            }

            decimal productCost = portions * (2 * bananas + 4 * eggs + (decimal)0.2 * berries);

            if (productCost <= money)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", productCost);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", productCost - money);
            }
        }
    }
}
