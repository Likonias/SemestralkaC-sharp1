using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    internal class Author
    {
        private String Name;
        private String Surname;
        private int BornInYear;
        private int? DiedInYear;
        private Book[] Books;

        public Author(string name, string surname, int bornInYear, int? diedInYear, Book[] books)
        {
            Name = name;
            Surname = surname;
            BornInYear = bornInYear;
            DiedInYear = diedInYear;
            Books = books;
        }
    }
}
