using System;
using System.Collections.Generic;

class Program
{
    static List<Book> collection = new List<Book>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Book Collection Manager ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All Books");
            Console.WriteLine("3. Search by Author");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewBooks();
                    break;
                case "3":
                    SearchByAuthor();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddBook()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Author: ");
        string author = Console.ReadLine();

        Console.Write("Genre: ");
        string genre = Console.ReadLine();

        int pages = ValidateInt("Page Count (positive number): ");
        double rating = ValidateDouble("Rating (0-5): ");

        Book book = new Book(title, author, genre, pages, rating);
        collection.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    static void ViewBooks()
    {
        if (collection.Count == 0)
        {
            Console.WriteLine("No books in collection.");
            return;
        }

        foreach (Book book in collection)
        {
            Console.WriteLine(book.GetBookSummary());
        }
    }

    static void SearchByAuthor()
    {
        Console.Write("Enter author name to search: ");
        string author = Console.ReadLine().ToLower();

        foreach (Book book in collection)
        {
            if (book.Author.ToLower().Contains(author))
            {
                Console.WriteLine(book.GetBookSummary());
            }
        }
    }

    static int ValidateInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            try
            {
                value = int.Parse(Console.ReadLine());
                if (value > 0) return value;
                Console.WriteLine("Enter a positive number.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }
    }

    static double ValidateDouble(string prompt)
    {
        double value;
        while (true)
        {
            Console.Write(prompt);
            try
            {
                value = double.Parse(Console.ReadLine());
                if (value >= 0 && value <= 5) return value;
                Console.WriteLine("Enter a rating between 0 and 5.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number.");
            }
        }
    }
}
