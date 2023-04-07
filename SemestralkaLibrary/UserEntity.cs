using SemestralkaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    public class UserEntity
    {
        private string name;
        private string surname;
        private List<Book> booksRead;
        private double timeSpentReading;
        private string eMail;
        private string userName;
        private string password;
        private bool isHashed;
        
        public String Name { get => name; set => name = value; }
        public String Surname { get => surname; set => surname = value; }
        public List<Book> BooksRead { get => booksRead; set => booksRead = value; }
        public double TimeSpentReading { get => timeSpentReading; set => timeSpentReading = value; }
        public String EMail { get => eMail; set => eMail = value; }
        public String UserName { get => userName; set => userName = value; }
        public String Password { get => password; init => password = value; }
        public bool IsHashed { get => isHashed; set => isHashed = value; }
        
        public UserEntity(string name, string surname, string userName, string password, string eMail, bool isHashed)
        {
            Name = name;
            Surname = surname;
            BooksRead = new List<Book>();
            TimeSpentReading = 0;
            UserName = userName;
            if (isHashed)
            {
                Password = password;
            }
            else
            {
                Password = PasswordHash.PasswordHashing(password);
                isHashed = true;
            }
            EMail = eMail;
            IsHashed = isHashed;
        }

    }
}
