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
        public Book Book { get => createdBook; set => createdBook = value; }
        public BooklistNewBook(List<Author> author, Book book)
        {
            InitializeComponent();
            createdBook = book;
            int bookAuthorIndex = -1;
            for (int i = 0; i < author.Count; i++)
            {
                comboBoxAuthor.Items.Add(author[i].FullName);
                if (author[i] == book.Author)
                {
                    bookAuthorIndex = i;
                }
            }
            if(createdBook != null) 
            {
                textBoxTitle.Text = createdBook.Title;
                textBoxYearReleased.Text = createdBook.ReleaseYear.ToString();
                comboBoxAuthor.SelectedIndex = bookAuthorIndex;
                textBoxAverageReadTime.Text = createdBook.AverageReadTime.ToString();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBoxYearReleased.Text, out int yearReleased);
                int.TryParse(textBoxAverageReadTime.Text, out int averageReadTime);
                if (textBoxTitle.Text.Length == 0 || textBoxAverageReadTime.Text.Length == 0 || textBoxYearReleased.Text.Length == 0)
                {
                    throw new Exception("Something went wrong, try again please!");
                }
                if(averageReadTime == 0)
                {
                    throw new Exception("Read time is wrong, try again please!");
                }


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
