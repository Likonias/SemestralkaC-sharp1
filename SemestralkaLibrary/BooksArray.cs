using SemestralkaMaybe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaLibrary
{
    
    public class BooksArray
    {

        private LinkedList<Book> books = new LinkedList<Book> ();



        public void AddBook(Book book)
        {
            books.AddLast (book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public Book FindBook(Book book)
        {
            foreach (Book bookCol in books) 
            {
                if (book.Equals(bookCol))
                {
                    return bookCol;
                }
            }
            return null;
        }

    }
}
