using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    public class Author
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public int BornInYear { get; set; }
        public int? DiedInYear { get; set; }
        public Book[] Books { get; set; }

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
