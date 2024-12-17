using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book:Item, IBorrowable
    {
        public string author { get; set; }
        public string ISBN
        {
            get => ISBN;
            set => ISBN = value;
        }

        public bool IsBorrowed {  get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Title:{Title}, Author:{author}, ISBN:{ISBN}");
        }

        public void Borrow()
        {
            if ( IsBorrowed )
            {
                Console.WriteLine("The book is already borroewd");
            }
            else
            {
                IsBorrowed = true;
                Console.WriteLine("The book has been borroewd");
            }
        }

        public void Return()
        {
            if (IsBorrowed = false)
            {
                IsBorrowed = false;
                Console.WriteLine("The book has been returned");
            }
            else
            {
                Console.WriteLine("The book was not borrowed");
            }
        }
    }
}
