using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library: IBorrowable
    {
        private List<Book> booklist = new List<Book>();

        public void AddBook(Book book)
        {
            booklist.Add(book);
            Console.WriteLine("Book'{book.Title}' added to the library");

        }

        public void DisplayBooks()
        {
            if (booklist.Count == 0)
            {
                Console.WriteLine("No books in library");
            }
            else
            {
                foreach (var book in booklist)
                {
                    book.DisplayInfo();

                }
            }

        } 
        
        public void Borrow()
        {
            Console.WriteLine("Borrowing from library directly is not allowed");

        }

        public void Return()
        {
            Console.WriteLine("Returning from library directly is not allowed");
        }
    }
}
