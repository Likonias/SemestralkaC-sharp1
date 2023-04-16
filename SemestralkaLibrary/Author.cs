using SemestralkaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    public class Author
    {
        private string name;
        private string surname;
        private int bornInYear;
        private int? diedInYear;
        private List<Book> books;
        public String Name { get => name; set => name = value; }
        public String Surname { get => surname; set => surname = value; }
        public int BornInYear { get => bornInYear; set => bornInYear = value; }
        public int? DiedInYear { get => diedInYear; set => diedInYear = value; }
        public List<Book> Books { get => books; set => books = value; }
        public String FullName { get => name + surname;}
        public Author(string name, string surname, int bornInYear, int? diedInYear, List<Book> books)
        {
            Name = name;
            Surname = surname;
            BornInYear = bornInYear;
            DiedInYear = diedInYear;
            Books = books;
        }
    }
}
