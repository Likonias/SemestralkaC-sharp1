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
        private string name;
        private string surname;
        private Book[] booksRead;
        private double timeSpentReading;
        private string eMail;
        private string userName;
        private string password;
        
        public String Name { get => name; set => name = value; }
        public String Surname { get => surname; set => surname = value; }
        public Book[] BooksRead { get => booksRead; set => booksRead = value; }
        public double TimeSpentReading { get => timeSpentReading; set => timeSpentReading = value; }
        public String EMail { get => eMail; set => eMail = value; }
        public String UserName { get => userName; set => userName = value; }
        public String Password { get => password; init => password = value; }

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
