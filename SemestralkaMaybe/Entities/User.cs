using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    internal class User
    {
        private String Name;
        private String Surname;
        private Book[] BooksRead;
        private double TimeSpentReading;
        private String UserName;
        private String Password;
        private String EMail;

        public User(string name, string surname, Book[] booksRead, double timeSpentReading, string userName, string password, string eMail)
        {
            Name = name;
            Surname = surname;
            BooksRead = booksRead;
            TimeSpentReading = timeSpentReading;
            UserName = userName;
            Password = password;
            EMail = eMail;
        }
    }
}
