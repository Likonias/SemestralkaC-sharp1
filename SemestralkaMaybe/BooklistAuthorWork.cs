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
    public partial class BooklistAuthorWork : Form
    {
        public BooklistAuthorWork(List<Book> books, Author selectedAuthor)
        {
            InitializeComponent();
            listViewWorks.View = View.Details;
            listViewWorks.Columns.Add("Title", 194);
            listViewWorks.Columns.Add("Author", 194);
            listViewWorks.Columns.Add("Release Year", 194);
            listViewWorks.Columns.Add("Average Read Time", 194);
            foreach (Book book in books)
            {
                if (selectedAuthor.FullName == book.Author.FullName)
                {
                    ListViewItem listViewItem = new ListViewItem(book.Title);
                    listViewItem.SubItems.Add(book.Author.FullName);
                    listViewItem.SubItems.Add(book.ReleaseYear.ToString());
                    listViewItem.SubItems.Add(book.AverageReadTime.ToString());
                    listViewWorks.Items.Add(listViewItem);
                }
            }
            //If the author doesnt have any books it automatically closes the window
            if(listViewWorks.Items.Count == 0)
            {
                this.Close();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
