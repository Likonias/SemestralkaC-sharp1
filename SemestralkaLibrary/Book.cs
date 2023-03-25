using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    public class Book
    {
        
        public String Title { get; set; }
        public int ReleaseYear { get; set; }
        public Author Author { get; set; }
        public String Date { get; set; }
        public int TimesRead { get; set; }
        public double AverageReadTime { get; set; }

        public Book(string title, int releaseYear, Author author, string date, int timesRead, double averageReadTime)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            Date = date;
            TimesRead = timesRead;
            AverageReadTime = averageReadTime;
        }
    }
}
