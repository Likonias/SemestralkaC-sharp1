using SemestralkaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    public class User
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public Book[] BooksRead { get; set; }
        public double TimeSpentReading { get; set; }
        public String EMail { get; set; }
        public String UserName { get; set; }

        public String Password { get; set; }

        private PasswordHash passwordHash = new PasswordHash();

        public User(string name, string surname, Book[] booksRead, double timeSpentReading, string userName, string password, string eMail)
        {
            Name = name;
            Surname = surname;
            BooksRead = booksRead;
            TimeSpentReading = timeSpentReading;
            UserName = userName;
            Password = passwordHash.PasswordHashing(password);
            EMail = eMail;
        }

        
    }
}
