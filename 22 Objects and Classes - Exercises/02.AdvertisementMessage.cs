using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] Phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] Events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] Author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int PhrasesIndex = rnd.Next(0, Phrases.Length);
                int EventsIndex = rnd.Next(0, Events.Length);
                int AuthorIndex = rnd.Next(0, Author.Length);
                int CitiesIndex = rnd.Next(0, Cities.Length);

                string output = Phrases[PhrasesIndex] + " " + Events[EventsIndex] + " " + Author[AuthorIndex] + " - " + Cities[CitiesIndex];

                Console.WriteLine(output);
            }
        }
    }
}

