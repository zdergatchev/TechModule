﻿using System;
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

        DateTime obsoletedData = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        List<Book> selection = MyLib.Books.Select(l => l)
                                          .Where(x => x.ReleaseDate > obsoletedData)
                                          .OrderBy(x => x.ReleaseDate)
                                          .ThenBy(x => x.Title)
                                          .ToList();

        foreach (var s in selection)
        {
            Console.WriteLine("{0} -> {1:dd.MM.yyyy}", s.Title, s.ReleaseDate);
        }
    }
}
