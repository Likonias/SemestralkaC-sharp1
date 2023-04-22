using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    public class Book
    {
        private string title;
        private int releaseYear;
        private Author author;
        private DateTime? dateRead;
        private int? timesRead;
        private double averageReadTime;
        public String Title { get => title; set => title = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public Author Author { get => author; set => author = value; }
        public DateTime? DateRead { get => dateRead; set => dateRead = value; }
        public int? TimesRead { get => timesRead; set => timesRead = value; }
        public double AverageReadTime { get => averageReadTime; set => averageReadTime = value; }

        public Book(string title, int releaseYear, Author author, DateTime? dateRead, int? timesRead, double averageReadTime)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            DateRead = dateRead;
            TimesRead = timesRead;
            AverageReadTime = averageReadTime;
        }
    }
}
