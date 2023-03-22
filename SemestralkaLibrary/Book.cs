using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralkaMaybe.Entities
{
    internal class Book
    {

        private String Title;
        private int ReleaseYear;
        private Author Author;
        private String Date;
        private int TimesRead;
        private double AverageReadTime;

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
