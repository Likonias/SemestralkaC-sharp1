using Microsoft.VisualBasic;
using SemestralkaMaybe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralkaMaybe
{
    public partial class BooklistNewBook : Form
    {
        private Book createdBook;
        private List<Author> authors;
        private int createdAuthorIndex;
        public Book CreatedBook { get => createdBook; }
        public BooklistNewBook(List<Author> author, Book book)
        {
            InitializeComponent();
            createdBook = book;
            authors = author;
            
            for (int i = 0; i < author.Count; i++)
            {
                comboBoxAuthor.Items.Add(author[i].FullName);
                if (book != null && book.Author.Equals(author[i]))
                {
                    createdAuthorIndex = i;
                }
            }
            if (createdBook != null)
            {
                textBoxTitle.Text = createdBook.Title;
                textBoxYearReleased.Text = createdBook.ReleaseYear.ToString();
                comboBoxAuthor.SelectedIndex = createdAuthorIndex;
                textBoxAverageReadTime.Text = createdBook.AverageReadTime.ToString();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBoxYearReleased.Text, out int yearReleased);
                int.TryParse(textBoxAverageReadTime.Text, out int averageReadTime);
                if (textBoxTitle.Text.Length == 0 || textBoxAverageReadTime.Text.Length == 0 || textBoxYearReleased.Text.Length == 0 || comboBoxAuthor.SelectedIndex < 0)
                {
                    throw new Exception("Something went wrong, try again please!");
                }
                if (averageReadTime == 0)
                {
                    throw new Exception("Read time is wrong, try again please!");
                }
                if(yearReleased == 0)
                {
                    throw new Exception("Year release is wrong, try again please!");
                }
                createdBook = new Book(textBoxTitle.Text, yearReleased, authors[comboBoxAuthor.SelectedIndex], null, null, averageReadTime);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            createdBook = null;
            this.Close();
        }

        
    }
}
