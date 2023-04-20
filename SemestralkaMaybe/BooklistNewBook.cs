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
        public BooklistNewBook()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                
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
