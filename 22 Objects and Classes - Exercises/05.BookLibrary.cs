using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


public class BookLibraryMain
{
    class Library
    {
        public Library()
        {
            this.Books = new List<Book>();
        }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Library MyLib = new Library();
        for (int i = 0; i < n; i++)
        {
            string[] bookInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            MyLib.Books.Add(new Book()
            {
                Title = bookInfo[0],
                Author = bookInfo[1],
                Publisher = bookInfo[2],
                ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                ISBN = bookInfo[4],
                Price = decimal.Parse(bookInfo[5])
            });
        }

        Dictionary<string, decimal> SelectByAutorAndPrice = new Dictionary<string, decimal>();

        foreach (string author in MyLib.Books.Select(x => x.Author).Distinct())
        {
            SelectByAutorAndPrice.Add(author, MyLib.Books.Where(x => x.Author == author)
                                           .Select(x => x.Price)
                                           .Sum());
        }

        foreach (var pair in SelectByAutorAndPrice
                            .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
        }
    }
}
