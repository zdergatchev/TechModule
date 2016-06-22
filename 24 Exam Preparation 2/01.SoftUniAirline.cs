using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
           int numFlights = int.Parse(Console.ReadLine());
           decimal totalProfit = 0;

            for (int i = 1; i <= numFlights; i++)
            {                
                long adultPassengersCount = long.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                long youthPassengersCount = long.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal income = (adultPassengersCount * adultTicketPrice) + (youthPassengersCount * youthTicketPrice);
                decimal expenses = flightDuration * (fuelConsumptionPerHour * fuelPricePerHour);
                decimal  profitPerFlyght = income - expenses;
                totalProfit += profitPerFlyght;

                if (totalProfit >= 0)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", profitPerFlyght);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", profitPerFlyght);
                }
            }
           
            Console.WriteLine("Overall profit -> {0:F3}$.", totalProfit);
            decimal averageProfit = totalProfit / numFlights;
            Console.WriteLine("Average profit -> {0:F3}$.", averageProfit);
        }
    }
}
