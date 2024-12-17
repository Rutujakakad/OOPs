// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using LibraryManagementSystem;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the library");
        Library library = new Library();
        Book book1 = new Book { Title = "Drama", author = "xyz", ISBN = "156bc" };
        Book book2 = new Book { Title = "adventure", author = "ybm", ISBN = "15dc" };
        Book book3 = new Book { Title = "Romance", author = "abx", ISBN = "456yrs" };

       
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        Console.WriteLine("\nDisplaying Library books");
        library.DisplayBooks();

        Console.WriteLine("\nBorrow 'Drama'");
        book1.Borrow();

        Console.WriteLine("\nBorrow 'drama' Again:");
        book1.Borrow();

        Console.WriteLine("Returning drama:");
        book1.Return();

        Console.WriteLine("\nDisplaying Library books again");
        library.DisplayBooks();






    }

}
