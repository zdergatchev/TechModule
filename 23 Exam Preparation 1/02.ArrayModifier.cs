using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] actions = command.Split(' ').ToArray();
                if (actions.Length > 1)
                {
                    long number1 = long.Parse(actions[1]);
                    long number2 = long.Parse(actions[2]);

                    if (actions[0] == "swap")
                    {
                        long temp = numbers[number1];
                        numbers[number1] = numbers[number2];
                        numbers[number2] = temp;
                    }
                    else if (actions[0] == "multiply")
                    {
                        numbers[number1] = numbers[number1] * numbers[number2];
                    }
                }

                if (actions[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i]--;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
