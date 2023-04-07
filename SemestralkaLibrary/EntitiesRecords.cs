using SemestralkaMaybe.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaLibrary
{
    
    public class EntitiesRecords : ISavableLoadable<Book>, ISavableLoadable<Author>, ISavableLoadable<UserEntity>
    {

        private List<Book> books = new List<Book> ();
        private List<Author> authors = new List<Author> ();
        private List<UserEntity> userEntities = new List<UserEntity> ();

        public List<Book> Books { get { return books; } }
        public List<Author> Authors { get { return authors; } }
        public List<UserEntity> UserEntities { get { return userEntities; } }
        public void AddBook(Book book)
        {
            books.Add(book);
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

        public void AddAuthor(Author author)
        {
            authors.Add(author);
        }

        public void RemoveAuthor(Author author)
        {
            authors.Remove(author);
        }

        public void AddUser(UserEntity user)
        {
            userEntities.Add(user);
        }

        public void RemoveUser(UserEntity user)
        {
            userEntities.Remove(user);
        }

        public Book[] Save()
        {
            Book[] booksArray = books.ToArray();
            return booksArray;
        }

        public void Load(Book[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                books.Add(data[i]);
            }
        }

        Author[] ISavableLoadable<Author>.Save()
        {
            Author[] authorsArray = authors.ToArray();
            return authorsArray;
        }

        public void Load(Author[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                authors.Add(data[i]);
            }
        }

        UserEntity[] ISavableLoadable<UserEntity>.Save()
        {
            UserEntity[] usersEntitiesArray = userEntities.ToArray();
            return usersEntitiesArray;
        }

        public void Load(UserEntity[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                userEntities.Add(data[i]);
            }
        }
    }
}
